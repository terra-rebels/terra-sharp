using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Core.Auth;

namespace TerraSharp.Client.Lcd.Api
{
    public class AuthzAPI : BaseAPI
    {
        public AuthzAPI(APIRequester apiRequester) : base(apiRequester)
        {
        }

        public Task<Account> GetGrants<T>(
            AccAddress granter,
            AccAddress grantee,
            string? msgTypeUrl,
            APIParams<T> @params)
        {
            throw new NotImplementedException();
        }
    }
}
