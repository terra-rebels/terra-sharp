using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class BatchProof
    {
        [ProtoMember(BatchProofTags.BATCH_PROOF_ENTRIES_TAG)]
        public BatchEntry[] Entries { get; set; }
    }
}
