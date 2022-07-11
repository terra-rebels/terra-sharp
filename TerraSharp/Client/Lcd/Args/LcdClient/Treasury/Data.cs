using TerraSharp.Core;

namespace TerraSharp.Client.Lcd.Args.LcdClient.Treasury
{
    public class Data
    {
        public string Seigniorage_burden_target { get; set; }
        public Dec Mining_increment { get; set; }
        public string Window_short { get; set; }
        public string Window_long { get; set; }
        public string Window_probation { get; set; }
    }
}
