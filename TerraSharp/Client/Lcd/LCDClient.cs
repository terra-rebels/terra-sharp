using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Client.Lcd.Api;
//using TerraSharp.Client.Lcd.Interfaces.LcdClient;

namespace TerraSharp.Client.Lcd
{
    public abstract class LCDClient
    {
        public string Url { get; set; }
        public string ChainId { get; set; }

        //public readonly ILCDClientConfig config;
        public readonly APIRequester apiRequester;

        public readonly AuthAPI auth;
        public readonly BankAPI bank;
        public readonly DistributionAPI distribution;
        public readonly FeeGrantAPI feeGrant;
        public readonly GovAPI gov;
        public readonly MarketAPI market;
        public readonly MintAPI mint;
        public readonly AuthzAPI authz;
        public readonly OracleAPI oracle;
        public readonly SlashingAPI slashing;
        public readonly StakingAPI staking;
        public readonly TendermintAPI tendermint;
        public readonly TreasuryAPI treasury;
        public readonly WasmAPI wasm;
        public readonly TXAPI tx;
        public readonly IBCTransferAPI ibcTransfer;
        public readonly LCDUtils utils;


        public LCDClient(
        //    ILCDClientConfig config,
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
            LCDUtils utils)
        {
            //   this.config = config;
            this.apiRequester = apiRequester;
            this.auth = auth;
            this.bank = bank;
            this.distribution = distribution;
            this.feeGrant = feeGrant;
            this.gov = gov;
            this.market = market;
            this.mint = mint;
            this.authz = authz;
            this.oracle = oracle;
            this.slashing = slashing;
            this.staking = staking;
            this.tendermint = tendermint;
            this.treasury = treasury;
            this.wasm = wasm;
            this.tx = tx;
            this.ibcTransfer = ibcTransfer;
            this.utils = utils;

            this.PrepareLCDClientInformation();
        }

        public Wallet CreateWallet(string key)
        {
            return new Wallet(this, key);
        }

        protected virtual void PrepareLCDClientInformation()
        {

        }

        protected abstract void PrepareClient(string url, string chainId);
    }
}
