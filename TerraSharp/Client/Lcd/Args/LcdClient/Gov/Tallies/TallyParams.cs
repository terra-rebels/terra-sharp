using TerraSharp.Core;

namespace TerraSharp.Client.Lcd.Args.LcdClient.Gov.Tallies
{
    public class TallyParams
    {
        public Dec Quorum { get; set; }
        public Dec Threshold { get; set; }
        public Dec Veto_Threshold { get; set; }
    }
}
