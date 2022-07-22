namespace TerraProto.CSharp.Confio
{
    public static class Proofs
    {
        public static object baseExistenceProof { get; set; }
        public static HashOp HasOpFromJSON(object data)
        {
            switch (data)
            {
                case 0:
                case "NO_HASH":
                    return HashOp.NO_HASH;
                case 1:
                case "SHA256":
                    return HashOp.SHA256;
                case 2:
                case "SHA512":
                    return HashOp.SHA512;
                case 3:
                case "KECCAK":
                    return HashOp.KECCAK;
                case 4:
                case "RIPEMD160":
                    return HashOp.RIPEMD160;
                case 5:
                case "BITCOIN":
                    return HashOp.BITCOIN;
                case -1:
                case "UNRECOGNIZED":
                default:
                    return HashOp.UNRECOGNIZED;
            }
        }
        public static string HasOpToJSON(HashOp data)
        {
            switch (data)
            {
                case HashOp.NO_HASH:
                    return "NO_HASH";
                case HashOp.SHA256:
                    return "SHA256";
                case HashOp.SHA512:
                    return "SHA512";
                case HashOp.KECCAK:
                    return "KECCAK";
                case HashOp.RIPEMD160:
                    return "RIPEMD160";
                case HashOp.BITCOIN:
                    return "BITCOIN";
                default:
                    return "UNKNOWN";
            }
        }
        public static LengthOp LengthOpFromJSON(object data)
        {
            switch (data)
            {
                case 0:
                case "NO_PREFIX":
                    return LengthOp.NO_PREFIX;
                case 1:
                case "VAR_PROTO":
                    return LengthOp.VAR_PROTO;
                case 2:
                case "VAR_RLP":
                    return LengthOp.VAR_RLP;
                case 3:
                case "FIXED32_BIG":
                    return LengthOp.FIXED32_BIG;
                case 4:
                case "FIXED32_LITTLE":
                    return LengthOp.FIXED32_LITTLE;
                case 5:
                case "FIXED64_BIG":
                    return LengthOp.FIXED64_BIG;
                case 6:
                case "FIXED64_LITTLE":
                    return LengthOp.FIXED64_LITTLE;
                case 7:
                case "REQUIRE_32_BYTES":
                    return LengthOp.REQUIRE_32_BYTES;
                case 8:
                case "REQUIRE_64_BYTES":
                    return LengthOp.REQUIRE_64_BYTES;
                case -1:
                case "UNRECOGNIZED":
                default:
                    return LengthOp.UNRECOGNIZED;
            }
        }

        public static string LengthOpToJSON(LengthOp data)
        {
            switch (data)
            {
                case LengthOp.NO_PREFIX:
                    return "NO_PREFIX";
                case LengthOp.VAR_PROTO:
                    return "VAR_PROTO";
                case LengthOp.VAR_RLP:
                    return "VAR_RLP";
                case LengthOp.FIXED32_BIG:
                    return "FIXED32_BIG";
                case LengthOp.FIXED32_LITTLE:
                    return "FIXED32_LITTLE";
                case LengthOp.FIXED64_BIG:
                    return "FIXED64_BIG";
                case LengthOp.FIXED64_LITTLE:
                    return "FIXED64_LITTLE";
                case LengthOp.REQUIRE_32_BYTES:
                    return "REQUIRE_32_BYTES";
                case LengthOp.REQUIRE_64_BYTES:
                    return "REQUIRE_64_BYTES";
                default:
                    return "UNKNOWN";
            }
        }
    }
}
