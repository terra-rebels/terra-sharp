using Ninject.Modules;
using Prism.Events;
using TerraSharp.Client.Lcd;
using TerraSharp.Configuration;
using TerraSharp.Http.Util;
using TerraSharp.Modules;
namespace TerraSharp.Modules
{
    public class TerraSharpMainModule : NinjectModule
    {
        public override void Load()
        {
            // Services
            this.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope(); /// Event Aggregator

            // Api Configuration
            this.Bind<APIRequester>().ToConstructor((e) => new APIRequester(""));

            // Http Services
            this.Bind<TerraRestfulService>().To<TerraRestfulService>().InSingletonScope();
            this.Bind<TerraHttpClientService>().To<TerraHttpClientService>().InSingletonScope();

            TerraHttpClientFactory.InitializeClientFactory(); // HttpClientFactory
            TerraHttpClientFactory.InitializeHttpClients(); // Prepare a Singleton of the HttpClient
        }
    }
}
