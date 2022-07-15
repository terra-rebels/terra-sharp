using Ninject.Modules;
using Prism.Events;
using TerraSharp.Client;
using TerraSharp.Client.Lcd;
using TerraSharp.Client.Lcd.Api;
using TerraSharp.Configuration;
using TerraSharp.Http.Util;

namespace TerraSharp.Modules
{
    public class TerraSharpMainModule : NinjectModule
    {
        public override void Load()
        {
            // Services
            this.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope(); /// Event Aggregator
            this.InitializeClientLcdApis();
            this.InitializeHttpServices();
        }

        private void InitializeHttpServices()
        {
            // Http Services
            this.Bind<TerraRestfulService>().To<TerraRestfulService>().InSingletonScope();
            this.Bind<TerraHttpClientService>().To<TerraHttpClientService>().InSingletonScope();

            TerraHttpClientFactory.InitializeClientFactory(); // HttpClientFactory
            TerraHttpClientFactory.InitializeHttpClients(); // Prepare a Singleton of the HttpClient
        }

        private void InitializeClientLcdApis()
        {
            //Lcd Client Services
          //  this.Bind<ILCDClientConfig>().To<LocalTerra>().InSingletonScope();

            // Api Configuration
            this.Bind<APIRequester>().ToConstructor((e) => new APIRequester(""));
            this.Bind<LocalTerra>().To<LocalTerra>().InSingletonScope();

            this.Bind<AuthAPI>().To<AuthAPI>().InSingletonScope();
            this.Bind<AuthzAPI>().To<AuthzAPI>().InSingletonScope();
            this.Bind<BankAPI>().To<BankAPI>().InSingletonScope();
            this.Bind<BaseAPI>().To<BaseAPI>().InSingletonScope();
            this.Bind<DistributionAPI>().To<DistributionAPI>().InSingletonScope();
            this.Bind<FeeGrantAPI>().To<FeeGrantAPI>().InSingletonScope();
            this.Bind<GovAPI>().To<GovAPI>().InSingletonScope();
            this.Bind<IBCAPI>().To<IBCAPI>().InSingletonScope();
            this.Bind<IBCTransferAPI>().To<IBCTransferAPI>().InSingletonScope();
            this.Bind<MarketAPI>().To<MarketAPI>().InSingletonScope();
            this.Bind<MintAPI>().To<MintAPI>().InSingletonScope();
            this.Bind<OracleAPI>().To<OracleAPI>().InSingletonScope();
            this.Bind<SlashingAPI>().To<SlashingAPI>().InSingletonScope();
            this.Bind<StakingAPI>().To<StakingAPI>().InSingletonScope();
            this.Bind<TendermintAPI>().To<TendermintAPI>().InSingletonScope();
            this.Bind<TreasuryAPI>().To<TreasuryAPI>().InSingletonScope();
            this.Bind<TXAPI>().To<TXAPI>().InSingletonScope();
            this.Bind<WasmAPI>().To<WasmAPI>().InSingletonScope();
        }
    }
}