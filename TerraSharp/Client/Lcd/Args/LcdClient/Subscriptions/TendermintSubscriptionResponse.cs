namespace TerraSharp.Client.Lcd.Args.LcdClient.Subscriptions
{
    public class TendermintSubscriptionResponse<T>
    {
        public string Type { get; set; }
        public KeyValuePair<string, T> Value { get; set; }
    }
}
