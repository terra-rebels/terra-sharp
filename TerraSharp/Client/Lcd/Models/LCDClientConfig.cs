namespace TerraSharp.Client.Lcd.Models
{
    public class LCDClientConfig
    {
        public string Url { get; set; }
        public string ChainID { get; set; }
        public string? GasPrices { get; set; }
        public double? GasAdjustment { get; set; }
    }
}
