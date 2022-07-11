using TerraSharp.Core;

namespace TerraSharp.Client.Lcd.Args.LcdClient.Rewards
{
    public class Rewards<T>
    {
        public KeyValuePair<string[], Coins<T>> Reward { get; set; }
        public Coins<T> Total { get; set; }
    }
}
