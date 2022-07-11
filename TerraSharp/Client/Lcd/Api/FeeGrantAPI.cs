using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Client.Lcd.Args.LcdClient.FeeGrants;
using TerraSharp.Core.Auth;

namespace TerraSharp.Client.Lcd.Api
{
    public class FeeGrantAPI : BaseAPI
    {
        public FeeGrantAPI(APIRequester apiRequester) : base(apiRequester)
        {
        }

        public Task<FeeGrantParamsArgs> GetAllowances(
            AccAddress grantee,
            APIParams<PaginationOptions> @params)
        {
            throw new NotImplementedException();
        }

        public Task<Allowance> GetSingleAllowance(
            AccAddress granter,
            AccAddress grantee)
        {
            throw new NotImplementedException();
        }
    }
}
