using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Crypto.RIPEMD;

namespace TerraSharp.Util
{
    public class Hash
    { 
        /**
         * 
         * TerraSharp.Util.Hash.hashtoHex: Converts specified string data into a Uppercase Hexadecimal Hash
         * Parameters: String data - The data to be converted
         *  
         *  Todo: Does not handle ArgumentNullException, but this was not checked in the original Typescript Implementation.
         *  Add Support for this if needed
         */
        
        public static string hashToHex(string data)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.ASCII.GetBytes(Convert.ToBase64String(Encoding.ASCII.GetBytes(data)))).ToString().ToUpper();
            }
        }

        /**
         * 
         * TerraSharp.Util.Hash.sha256: Converts specified string data into a SHA256 Value
         * Parameters: String data - The data to be converted
         *  
         */

        public static byte[] sha256(string data)
        {
            using (SHA256 hash = SHA256.Create())
            {
                return hash.ComputeHash(Encoding.ASCII.GetBytes(data));
            }
        }

        /**
        * 
        * TerraSharp.Util.Hash.ripemd160: Converts specified string data into a RIPEMD160 Value
        * Parameters: String data - The data to be converted
        *  
        */

        public static byte[] ripemd160(string data)
        {
            using(RIPEMD160 rpmd = new RIPEMD160Managed())
            {
                return rpmd.ComputeHash(Encoding.ASCII.GetBytes(data));
            }
        }

    }
}
