using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Core.Auth;

namespace TerraSharp.Client.Lcd.Api
{
    public class AuthAPI : BaseAPI
    {
        public AuthAPI(APIRequester apiRequester) : base(apiRequester)
        {
        }

        public Task<Account> GetAccountInfo<T>(AccAddress address, APIParams<T> @params)
        {
            throw new NotImplementedException();
        }
    }
}
