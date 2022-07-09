using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Client.Lcd.Api;
using TerraSharp.Client.Lcd.Interfaces.LcdClient;

namespace TerraSharp.Client.Lcd
{
    public class LCDClient
    {
        private readonly ILCDClientConfig config;
        private readonly APIRequester apiRequester;

        private readonly AuthAPI auth;
        private readonly BankAPI bank;
        private readonly DistributionAPI distribution;
        private readonly FeeGrantAPI feeGrant;
        private readonly GovAPI gov;
        private readonly MarketAPI market;
        private readonly MintAPI mint;
        private readonly AuthzAPI authz;
        private readonly OracleAPI oracle;
        private readonly SlashingAPI slashing;
        private readonly StakingAPI staking;
        private readonly TendermintAPI tendermint;
        private readonly TreasuryAPI treasury;
        private readonly WasmAPI wasm;
        private readonly TXAPI tx;
        private readonly IBCTransferAPI ibcTransfer;
        private readonly LCDUtils utils;


        public LCDClient(
            ILCDClientConfig config,
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
            this.config = config;
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
        }

    }
}
