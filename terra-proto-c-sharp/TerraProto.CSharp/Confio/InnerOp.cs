using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class InnerOp
    {
        [ProtoMember(InnerOpTags.HASH_TAG)]
        public HashOp Hash { get; set; }
        [ProtoMember(InnerOpTags.PREFIX_TAG)]
        public byte[] Prefix { get; set; }
        [ProtoMember(InnerOpTags.SUFFIX_TAG)]
        public byte[] Suffix { get; set; }
    }
}
