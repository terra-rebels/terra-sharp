using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class CompressedNonExistenceProof
    {
        [ProtoMember(CompressedNonExistenceProofTags.KEY_TAG)]
        public byte[] Key { get; set; }

        [ProtoMember(CompressedNonExistenceProofTags.LEFT_TAG)]
        public CompressedExistenceProof? Left { get; set; }

        [ProtoMember(CompressedNonExistenceProofTags.RIGHT_TAG)]
        public CompressedExistenceProof? Right { get; set; }
    }
}
