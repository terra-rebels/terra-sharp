using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraSharp.Client.Lcd.Api
{
    public class TreasuryAPI
    {
        private readonly APIRequester apiRequester;
        public TreasuryAPI(APIRequester apiRequester)
        {
            this.apiRequester = apiRequester;
        }
    }
}
