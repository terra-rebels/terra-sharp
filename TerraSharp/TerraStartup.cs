using Ninject.Modules;
using Prism.Events;
using TerraSharp.Client.Lcd;
using TerraSharp.Configuration;
using TerraSharp.Http.Util;

namespace TerraSharp
{
    public class TerraStartup : NinjectModule
    {
        public override void Load()
        {
            TerraHttpClientFactory.InitializeClientFactory(); // HttpClientFactory

            // Services
            this.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope(); /// Event Aggregator

            // Api Configuration
            this.Bind<APIRequester>().ToConstructor((e) => new APIRequester(""));
            this.Bind<TerraRestfulService>().To<TerraRestfulService>().InSingletonScope();

            // Http Services
            this.Bind<TerraRestfulService>().To<TerraRestfulService>().InSingletonScope();
            this.Bind<TerraHttpClientService>().To<TerraHttpClientService>().InSingletonScope();
        }
    }
}
