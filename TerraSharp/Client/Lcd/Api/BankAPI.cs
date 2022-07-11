using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Core.Auth;

namespace TerraSharp.Client.Lcd.Api
{
    public class BankAPI : BaseAPI
    {
        public BankAPI(APIRequester apiRequester) : base(apiRequester)
        {
        }

        public Task<Account> GetBalance<T, U>(
            AccAddress address,
            APIParams<T> @params)
        {
            throw new NotImplementedException();
        }

        public Task<Account> GetTotal<T>(APIParams<T> @params)
        {
            throw new NotImplementedException();
        }
    }
}
