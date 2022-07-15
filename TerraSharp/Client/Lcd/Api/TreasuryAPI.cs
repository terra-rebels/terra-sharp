using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Client.Lcd.Args.LcdClient.Treasury;
using TerraSharp.Core;

namespace TerraSharp.Client.Lcd.Api
{
    public class TreasuryAPI : BaseAPI
    {
        public TreasuryAPI(APIRequester apiRequester) : base(apiRequester)
        {
        }

        public async Task<Coins<T>> TaxCaps<T>(APIParams<string> @params)
        {
            throw new NotImplementedException("");
        }

        public async Task<Coin> TaxCap(APIParams<string> @params)
        {
            throw new NotImplementedException("");
        }

        public async Task<Dec> TaxRate(APIParams<string> @params)
        {
            throw new NotImplementedException("");
        }
        public async Task<Dec> RewardWeight(APIParams<string> @params)
        {
            throw new NotImplementedException("");
        }
        public async Task<Coins<T>> TaxProceeds<T>(APIParams<string> @params)
        {
            throw new NotImplementedException("");
        }
        public async Task<Coin> SeigniorageProceeds(APIParams<string> @params)
        {
            throw new NotImplementedException("");
        }
        public async Task<TreasuryParamsArgs> Parameters(APIParams<string> @params)
        {
            throw new NotImplementedException("");
        }
    }
}
