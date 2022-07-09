namespace TerraSharp.Client.Lcd.Interfaces.LcdClient
{
    public interface ILCDClientConfig
    {
        string Url { get; set; }
        string ChainID { get; set; }
        string? GasPrices { get; set; }
        double? GasAdjustment { get; set; }
    }
}
