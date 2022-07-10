using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Extension.StringExt;

namespace TerraSharp.Util
{
    public abstract class JSONSerializable<A, D, P>
    {
        public abstract A ToAmino();
        public abstract D ToData();
        public abstract P ToProto();
        public string ToJson() => Newtonsoft.Json.JsonConvert.SerializeObject(JsonWebExtensions.PrepareSignBytes((object)this.ToData()));
        public string ToAminoJson() => Newtonsoft.Json.JsonConvert.SerializeObject(JsonWebExtensions.PrepareSignBytes((object)this.ToAmino()));
    }
}
