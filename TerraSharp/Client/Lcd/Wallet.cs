using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Client.Lcd.Args;

namespace TerraSharp.Client.Lcd
{
    public class Wallet
    {
        private readonly LCDClient lcd;
        private readonly string key;

        public Wallet(LCDClient lcd, string key)
        {
            this.lcd = lcd;
            this.key = key;
        }

        public Task<AccountNumberArgs> AccountNumberAndSequence()
        {
            this.lcd.auth.
        }
    }
}
