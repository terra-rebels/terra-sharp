namespace TerraProto.CSharp.Extension.Proto
{
    public static class ProtoExtensions
    {
        public static T DeserialiseFromBytes<T>(this byte[] data) => ProtoBuf.Serializer.Deserialize<T>(new MemoryStream(data));
        public static byte[] SerialiseFromData<T>(this T data) where T : class, new()
        {
            using (var stream = new MemoryStream())
            {
                ProtoBuf.Serializer.Serialize<T>(stream, data);
                return stream.ToArray();
            }
        }

        public static byte[] SerialiseFromBase64Data(this string data)
        {
            using (var stream = new MemoryStream())
            {
                ProtoBuf.Serializer.Serialize(stream, Convert.FromBase64String(data));
                return stream.ToArray();
            }
        }
    }
}
