using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Core.Auth;

namespace TerraSharp.Client.Lcd.Api
{
    public class AuthAPI
    {
        private readonly APIRequester apiRequester;
        public AuthAPI(APIRequester apiRequester)
        {
            this.apiRequester = apiRequester;
        }

        //public Task<Account> GetAccountInfo(AccAddress)
        //{

        //}
    }
}
