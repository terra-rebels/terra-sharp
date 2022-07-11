using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Core;

namespace TerraSharp.Client.Lcd.Args.LcdClient.Distribution
{
    public class DistributionParamsArgs
    {
        public Dec Community_Tax { get; set; }
        public Dec Base_Proposer_Reward { get; set; }
        public Dec Bonus_Proposer_Reward { get; set; }
        public Dec Withdraw_Addr_Enabled { get; set; }
    }
}
