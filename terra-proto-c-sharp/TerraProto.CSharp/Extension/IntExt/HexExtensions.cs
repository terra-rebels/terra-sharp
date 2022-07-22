namespace TerraProto.CSharp.Extension.IntExt
{
    public static class HexExtensions
    {
        public static decimal GetDecimalFromHex(this string hexCode) => Convert.ToInt32(hexCode, 16);
        public static double GetDoubleFromHex(this string hexCode) => (double)Convert.ToInt32(hexCode, 16);
        public static string GetHexFromDouble(this double dbValue) => BitConverter.DoubleToInt64Bits(dbValue).ToString("X");
    }
}
