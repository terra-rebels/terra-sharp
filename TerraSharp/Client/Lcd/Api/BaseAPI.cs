using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraSharp.Client.Lcd.Api
{
    public class BaseAPI
    {
        private readonly APIRequester apiRequester;
        public BaseAPI(APIRequester apiRequester)
        {
            this.apiRequester = apiRequester;
        }
    }
}
