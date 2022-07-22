using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class CompressedBatchProof
    {
        [ProtoMember(CompressedBatchProofTags.COMPRESSED_BATCH_PROOF_ENTRIES_TAG)]
        public CompressedBatchEntry[] Entries { get; set; }

        [ProtoMember(CompressedBatchProofTags.LOOKUP_INNERS_TAG)]
        public InnerOp[] LookupInners { get; set; }
    }
}
