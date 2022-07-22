namespace TerraProto.CSharp.Confio
{
    public enum LengthOp
    {
        /** NO_PREFIX - NO_PREFIX don't include any length info */
        NO_PREFIX = 0,
        /** VAR_PROTO - VAR_PROTO uses protobuf (and go-amino) varint encoding of the length */
        VAR_PROTO = 1,
        /** VAR_RLP - VAR_RLP uses rlp int encoding of the length */
        VAR_RLP = 2,
        /** FIXED32_BIG - FIXED32_BIG uses big-endian encoding of the length as a 32 bit integer */
        FIXED32_BIG = 3,
        /** FIXED32_LITTLE - FIXED32_LITTLE uses little-endian encoding of the length as a 32 bit integer */
        FIXED32_LITTLE = 4,
        /** FIXED64_BIG - FIXED64_BIG uses big-endian encoding of the length as a 64 bit integer */
        FIXED64_BIG = 5,
        /** FIXED64_LITTLE - FIXED64_LITTLE uses little-endian encoding of the length as a 64 bit integer */
        FIXED64_LITTLE = 6,
        /** REQUIRE_32_BYTES - REQUIRE_32_BYTES is like NONE, but will fail if the input is not exactly 32 bytes (sha256 output) */
        REQUIRE_32_BYTES = 7,
        /** REQUIRE_64_BYTES - REQUIRE_64_BYTES is like NONE, but will fail if the input is not exactly 64 bytes (sha512 output) */
        REQUIRE_64_BYTES = 8,
        UNRECOGNIZED = -1,
    }
}
