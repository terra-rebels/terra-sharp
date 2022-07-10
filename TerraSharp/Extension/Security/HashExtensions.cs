using Crypto.RIPEMD;

namespace TerraSharp.Extension.Security
{
    public static class HashExtensions
    {
        public static string GetSha256(string data) => new Plugin.Security.Core.PasswordEncoder().Encode(data, Plugin.Security.Core.EncryptType.SHA_256);
        public static string Get(string data) => RIPEMD160Managed.HashInString(data);
    }
}
