using System.Net.Sockets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Polly;
using Polly.Extensions.Http;
using TerraSharp.Constants;
using TerraSharp.Extension.Logging.Serilog;
using TerraSharp.Extension.Platform;
using TerraSharp.Http;

namespace TerraSharp.Configuration
{
    public class TerraHttpClientFactory
    {
        private static IServiceProvider serviceProvider;

        /// <summary>
        /// Initializes the HttpClientFactory.
        /// </summary>
        /// <param name="container">iOC Container used for Registration.</param>
        public static void InitializeClientFactory()
        {
            // Android requires a DefaultHostBuilder to prevent runtime exceptions
            var host = TerraPlatformHelper.IsAndroid() ? Host.CreateDefaultBuilder()
                   .ConfigureServices(InitializeHttpServices).Build() : new HostBuilder()
                   .ConfigureServices(InitializeHttpServices)
                   .Build();

            serviceProvider = host.Services;
        }

        /// <summary>
        /// On HttpClient Initialization (Call this Method, to retrieve the HttpService).
        /// </summary>
        /// <typeparam name="T">Service Type.</typeparam>
        /// <returns>HttpClient Object.</returns>
        public static T GetService<T>()
        {
            return serviceProvider.GetService<T>();
        }

        private static bool CatchSocketException(SocketException socketIssue)
        {
            socketIssue.LogException(); // Log Any Exceptions in Serilog Data Store
            return true;
        }

        private static IAsyncPolicy<HttpResponseMessage> GetPollyRetryPolicies()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .OrInner<SocketException>((error) => CatchSocketException(error))
                .Or<SocketException>((error) => CatchSocketException(error))
                .WaitAndRetryAsync(3, (retryAttempt) => TimeSpan.FromSeconds(HttpBehaviourConstants.DefaultHttpTimeoutSeconds));
        }

        private static void InitializeHttpServices(IServiceCollection services)
        {
            services.AddHttpClient<TerraNativeHttpClient>(TerraHttpClientNames.TERRAHTTP, client =>
            {
                client.Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite);
            }).AddPolicyHandler(GetPollyRetryPolicies());
        }

        public static HttpClient GetHttpClientFromFactory()
        {
            return GetService<IHttpClientFactory>().CreateClient(TerraHttpClientNames.TERRAHTTP);
        }


        public static async void InitializeHttpClients()
        {
            ContainerLocator.Container.Resolve<IRestfulService>().PrepareHttpClientFromConsumer(PollyHttpClientConfigurator.GetHttpClientFromFactory());
        }

    }
}
