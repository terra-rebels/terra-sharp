using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Client.Constants;
using TerraSharp.Client.Lcd;
using TerraSharp.Client.Lcd.Api;
using TerraSharp.Constants;

namespace TerraSharp.Client
{
    public class LocalTerra : LCDClient
    {
        public readonly Wallet[] Wallets;

        public LocalTerra(
            APIRequester apiRequester,
            AuthAPI auth,
            BankAPI bank,
            DistributionAPI distribution,
            FeeGrantAPI feeGrant,
            GovAPI gov,
            MarketAPI market,
            MintAPI mint,
            AuthzAPI authz,
            OracleAPI oracle,
            SlashingAPI slashing,
            StakingAPI staking,
            TendermintAPI tendermint,
            TreasuryAPI treasury,
            WasmAPI wasm,
            TXAPI tx,
            IBCTransferAPI ibcTransfer,
            LCDUtils utils) : base(
                apiRequester,
                auth,
                bank,
                distribution,
                feeGrant,
                gov,
                market,
                mint,
                authz,
                oracle,
                slashing,
                staking,
                tendermint,
                treasury,
                wasm,
                tx,
                ibcTransfer,
                utils)
        {
            this.PrepareClient(ResourceUrls.TERRA_DEV_ROUTE, ChainKeys.TERRA_CHAINID);

            this.Wallets = new Wallet[] {
                this.CreateWallet(LocalTerraMnemonics.Validator),
                this.CreateWallet(LocalTerraMnemonics.Test1),
                this.CreateWallet(LocalTerraMnemonics.Test2),
                this.CreateWallet(LocalTerraMnemonics.Test3),
                this.CreateWallet(LocalTerraMnemonics.Test4),
                this.CreateWallet(LocalTerraMnemonics.Test5),
                this.CreateWallet(LocalTerraMnemonics.Test6),
                this.CreateWallet(LocalTerraMnemonics.Test7),
                this.CreateWallet(LocalTerraMnemonics.Test8),
                this.CreateWallet(LocalTerraMnemonics.Test9),
                this.CreateWallet(LocalTerraMnemonics.Test10),
            };
        }

        protected override void PrepareClient(string url, string chainId)
        {
            this.Url = url;
            this.ChainId = chainId;
        }
    }
}
