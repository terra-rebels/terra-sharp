using TerraSharp.Core;

namespace TerraSharp.Client.Lcd.Args.LcdClient.Treasury
{
    public class TreasuryParamsArgs
    {
        public Dec Seigniorage_burden_target { get; set; }
        public Dec Mining_increment { get; set; }
        public int Window_short { get; set; }
        public long Window_long { get; set; }
        public int Window_probation { get; set; }
    }
}
