using System.Text;

namespace TerraProto.CSharp.Extension.StringExt
{
    public static class PublicKeyExtensions
    {
        public static byte[] PubkeyAminoPrefixSecp256k1
        {
            get => TerraStringExtensions.GetBytesFromString(Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Concat("eb5ae987", "21"))));
        }

        public static byte[] PubkeyAminoPrefixEd25519
        {
            get => TerraStringExtensions.GetBytesFromString(Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Concat("1624de64", "20"))));
        }

        public static byte[] PubkeyAminoPrefixMultisigThreshold
        {
            get => TerraStringExtensions.GetBytesFromString(Convert.ToBase64String(Encoding.UTF8.GetBytes("22c1f7e2")));
        }


        public static byte[] EncodeUvarint(int @checked)
        {
            if (@checked > 127)
            {
                throw new Exception("Encoding numbers > 127 is not supported here. Please tell those lazy CosmJS maintainers to port the binary.PutUvarint implementation from the Go standard library and write some tests.");
            }

            return new byte[] { Convert.ToByte(@checked) };
        }
    }
}
