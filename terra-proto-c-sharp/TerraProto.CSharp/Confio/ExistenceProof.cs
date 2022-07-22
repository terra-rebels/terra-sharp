using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class ExistenceProof
    {
        [ProtoMember(ExistenceProofTags.KEY_TAG)]
        public byte[] Key { get; set; }

        [ProtoMember(ExistenceProofTags.VALUE_TAG)]
        public byte[] Value { get; set; }

        [ProtoMember(ExistenceProofTags.LEAF_TAG)]
        public LeafOp? Leaf { get; set; }

        [ProtoMember(ExistenceProofTags.PATH_TAG)]
        public InnerOp Path { get; set; }
    }
}
