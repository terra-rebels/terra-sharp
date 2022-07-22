using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class BatchEntry
    {
        [ProtoMember(BatchEntryTags.EXIST_TAG)]
        public ExistenceProof? Exist { get; set; }

        [ProtoMember(BatchEntryTags.NON_EXIST_TAG)]
        public NonExistenceProof? NonExist { get; set; }
    }
}
