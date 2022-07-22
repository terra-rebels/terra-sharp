using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraProto.CSharp.Cosmos.Auth.V1Beta1.Args
{
    public class BaseAccount
    {
        public string Address { get; set; }
        public object? PubKey { get; set; }
        public long AccountNumber { get; set; }
        public long Sequence { get; set; }
    }
}
