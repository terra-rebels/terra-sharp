using ProtoBuf;
using TerraProto.CSharp.Confio.Constants;

namespace TerraProto.CSharp.Confio
{
    [ProtoContract]
    public class ProofSpec
    {
        [ProtoMember(ProofSpecTags.LEAF_SPEC_TAG)]
        public LeafOp? LeafSpec { get; set; }

        [ProtoMember(ProofSpecTags.INNER_SPEC_TAG)]
        public InnerSpec? InnerSpec { get; set; }

        [ProtoMember(ProofSpecTags.MAX_DEPTH_TAG)]
        public long MaxDepth { get; set; }

        [ProtoMember(ProofSpecTags.MIN_DEPTH_TAG)]
        public long MinDepth { get; set; }
    }
}
