using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class CompressedBatchEntry
    {
        [ProtoMember(CompressedBatchEntryTags.EXIST_TAG)]
        public CompressedExistenceProof? Exist { get; set; }

        [ProtoMember(CompressedBatchEntryTags.NON_EXIST_TAG)]
        public CompressedNonExistenceProof? NonExist { get; set; }
    }
}
