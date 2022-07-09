using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraSharp.Client.Lcd.Api
{
    public class TXAPI
    {
        private readonly APIRequester apiRequester;
        public TXAPI(APIRequester apiRequester)
        {
            this.apiRequester = apiRequester;
        }
    }
}
