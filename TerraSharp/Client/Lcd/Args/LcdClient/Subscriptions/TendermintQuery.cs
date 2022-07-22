namespace TerraSharp.Client.Lcd.Args.LcdClient.Subscriptions
{
    public class TendermintQuery<T>
    {
        public KeyValuePair<string, T> Query { get; set; }
}
}
