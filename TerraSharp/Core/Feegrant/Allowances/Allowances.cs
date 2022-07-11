using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Client.Lcd.Args.LcdClient.FeeGrants;
using TerraSharp.Core.Auth;

namespace TerraSharp.Core.Feegrant.Allowances
{
    public class Allowances
    {
        public AccAddress Granter { get; set; }
        public AccAddress Grantee { get; set; }
        public Allowance Allowance { get; set; }
    }
}
