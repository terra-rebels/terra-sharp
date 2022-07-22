using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class InnerSpec
    {
        [ProtoMember(InnerSpecTags.CHILD_ORDER_TAG)]
        public byte[] ChildOrder { get; set; }

        [ProtoMember(InnerSpecTags.CHILD_SIZE_TAG)]
        public byte[] ChildSize { get; set; }

        [ProtoMember(InnerSpecTags.MIN_PREFIX_LENGTH_TAG)]
        public long MinPrefixLength { get; set; }

        [ProtoMember(InnerSpecTags.MAX_PREFIX_LENGTH_TAG)]
        public long MaxPrefixLength { get; set; }

        [ProtoMember(InnerSpecTags.EMPTY_CHILD_TAG)]
        public byte[] EmptyChild { get; set; }

        [ProtoMember(InnerSpecTags.HASH_TAG)]
        public HashOp Hash { get; set; }
    }
}
