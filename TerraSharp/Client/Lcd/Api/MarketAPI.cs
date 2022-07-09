using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraSharp.Client.Lcd.Api
{
    public class MarketAPI
    {
        private readonly APIRequester apiRequester;
        public MarketAPI(APIRequester apiRequester)
        {
            this.apiRequester = apiRequester;
        }
    }
}
