using TerraSharp.Client.Lcd.Args.LcdClient.Distribution;
using TerraSharp.Client.Lcd.Args.LcdClient.Rewards;
using TerraSharp.Core;
using TerraSharp.Core.Auth;

namespace TerraSharp.Client.Lcd.Api
{
    public class DistributionAPI : BaseAPI
    {
        public DistributionAPI(APIRequester apiRequester) : base(apiRequester)
        {
        }

        public Task<Rewards<T>> GetRewards<T>(
            AccAddress delegator,
            APIParams<T> @params)
        {
            throw new NotImplementedException();
        }
        public Task<Coins<T>> GetValidatorCommission<T>(
            ValAddress delegator,
            APIParams<T> @params)
        {
            throw new NotImplementedException();
        }

        public Task<AccAddress> GetWithdrawAddress<T>(
         AccAddress delegator,
         APIParams<T> @params)
        {
            throw new NotImplementedException();
        }

        public Task<Coins<T>> GetCommunityPool<T>(APIParams<T> @params)
        {
            throw new NotImplementedException();
        }

        public Task<DistributionParamsArgs> GetParameters<T>(APIParams<T> @params)
        {
            throw new NotImplementedException();
        }
    }
}
