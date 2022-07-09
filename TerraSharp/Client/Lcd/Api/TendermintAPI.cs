using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraSharp.Client.Lcd.Api
{
    public class TendermintAPI
    {
        private readonly APIRequester apiRequester;
        public TendermintAPI(APIRequester apiRequester)
        {
            this.apiRequester = apiRequester;
        }
    }
}
