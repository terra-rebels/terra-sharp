using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class LeafOp
    {
        [ProtoMember(LeafOpTags.HASH_TAG)]
        public HashOp? Hash { get; set; }

        [ProtoMember(LeafOpTags.PRE_HASH_KEY_TAG)]
        public HashOp? PreHashKey { get; set; }

        [ProtoMember(LeafOpTags.PRE_HASH_VALUE_TAG)]
        public HashOp? PreHashValue { get; set; }

        [ProtoMember(LeafOpTags.LENGTH_TAG)]
        public LengthOp? Length { get; set; }

        [ProtoMember(LeafOpTags.PREFIX_TAG)]
        public byte[] Prefix { get; set; }
    }
}
