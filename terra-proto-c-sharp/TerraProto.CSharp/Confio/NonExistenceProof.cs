using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class NonExistenceProof
    {
        [ProtoMember(NonExistenceProofTags.KEY_TAG)]
        public byte[] Key { get; set; }

        [ProtoMember(NonExistenceProofTags.LEFT_TAG, IsRequired = false)]
        public ExistenceProof? Left { get; set; }

        [ProtoMember(NonExistenceProofTags.RIGHT_TAG, IsRequired = false)]
        public ExistenceProof? Right { get; set; }

    }
}
