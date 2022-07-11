using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Core;
using TerraSharp.Core.Auth;

namespace TerraSharp.Key
{
    public abstract class Key
    {
        private readonly PublicKey? publicKey;
        public Key(PublicKey? publicKey) {
            this.publicKey = publicKey;
        }
        public abstract Task<byte[]> Sign(byte[] payload);

        public AccAddress AccAddress
        {
            get
            {
                return this.publicKey == null ? throw new Exception("Could not compute accAddress: missing rawAddress") : this.publicKey!.address
            }
        }
    }
}
