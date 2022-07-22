namespace TerraProto.CSharp.Confio
{
    public enum HashOp
    { 
        /** NO_HASH - NO_HASH is the default if no data passed. Note this is an illegal argument some places. */
        NO_HASH = 0,
        SHA256 = 1,
        SHA512 = 2,
        KECCAK = 3,
        RIPEMD160 = 4,
        /** BITCOIN - ripemd160(sha256(x)) */
        BITCOIN = 5,
        UNRECOGNIZED = -1,
    }
}
