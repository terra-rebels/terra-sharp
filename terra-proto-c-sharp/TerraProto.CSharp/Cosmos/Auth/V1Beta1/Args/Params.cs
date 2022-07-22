namespace TerraProto.CSharp.Cosmos.Auth.V1Beta1.Args
{
    public class Params
    {
        public long MaxMemoCharacters { get; set; }
        public long TxSigLimit { get; set; }
        public long TxSizeCostPerByte { get; set; }
        public long SigVerifyCostEd25519 { get; set; }
        public long SigVerifyCostSec256k1 { get; set; }
    }
}
