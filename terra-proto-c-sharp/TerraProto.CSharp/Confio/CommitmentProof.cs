using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class CommitmentProof
    {
        [ProtoMember(CommitmentProofTags.EXIST_TAG)]
        public ExistenceProof? Exist { get; set; }

        [ProtoMember(CommitmentProofTags.NON_EXIST_TAG)]
        public NonExistenceProof? NonExist { get; set; }

        [ProtoMember(CommitmentProofTags.BATCH_TAG)]
        public BatchProof? Batch { get; set; }

        [ProtoMember(CommitmentProofTags.COMPRESSED_TAG)]
        public CompressedBatchProof? Compressed { get; set; }
    }
}
