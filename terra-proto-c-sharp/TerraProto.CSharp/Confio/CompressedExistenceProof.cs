using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class CompressedExistenceProof
    {
        [ProtoMember(CompressedExistenceProofTags.KEY_TAG)]
        public byte[] Key { get; set; }

        [ProtoMember(CompressedExistenceProofTags.VALUE_TAG)]
        public byte[] Value { get; set; }

        [ProtoMember(CompressedExistenceProofTags.LEAF_TAG)]
        public LeafOp? Leaf { get; set; }

        [ProtoMember(CompressedExistenceProofTags.PATH_TAG)]
        public byte[] Path { get; set; }
    }
}
