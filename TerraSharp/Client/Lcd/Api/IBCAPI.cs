using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraSharp.Client.Lcd.Api
{
    public class IBCAPI
    {
        private readonly APIRequester apiRequester;
        public IBCAPI(APIRequester apiRequester)
        {
            this.apiRequester = apiRequester;
        }
    }
}
