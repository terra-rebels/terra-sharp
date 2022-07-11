using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Core;

namespace TerraSharp.Client.Lcd
{
    public class LCDUtils
    {
        public readonly LCDClient lcd;
        public LCDUtils(LCDClient lcd)
        {
            this.lcd = lcd;
        }

        public async Task<Coin> CalculateTax(Coin coin)
        {
            var rate = await this.lcd.treasury.tax
        }
    }
}
