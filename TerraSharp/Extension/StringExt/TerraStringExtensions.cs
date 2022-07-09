using System.Text;

namespace TerraSharp.Extension.StringExt
{
    public static class TerraStringExtensions
    {
        public static bool ContainsIgnoreCase(this string source, string verify) => source.ToLower().Contains(verify.ToLower());

        public static string FormatJson(this string json)
        {
            if (!string.IsNullOrWhiteSpace(json))
            {
                StringBuilder jsonFormatter = new StringBuilder();
                jsonFormatter.Append(json);
                jsonFormatter.Replace("\\", string.Empty);
                return jsonFormatter.ToString().Trim('"');
            }
            else
                return json;
        }

        /// <summary>
        /// Return either the attribute string or a default value.
        /// </summary>
        /// <param name="result">The processed string.</param>
        /// <param name="defaultString">The default string to process.</param>
        /// <returns>Return either the "result" or a default string. If no default string specified, returns "Unknown".</returns>
        public static string GetStringOrDefault(this string result, string defaultString = "Unknown") => string.IsNullOrWhiteSpace(result) ? defaultString : result;

        public static string GenerateCleanStringFromAscii(this string result)
        {
            return Encoding.ASCII.GetString(Encoding.Convert(
        Encoding.UTF8,
        Encoding.GetEncoding(
            Encoding.ASCII.EncodingName,
            new EncoderReplacementFallback(string.Empty),
            new DecoderExceptionFallback()
            ),
        Encoding.UTF8.GetBytes(result)));
        }

        /// <summary>
        /// Get String from a memory Stream.
        /// </summary>
        /// <param name="memoryStream"></param>
        /// <returns></returns>
        public static string GetStringFromStream(Stream memoryStream) => new StreamReader(memoryStream).ReadToEnd();

        /// <summary>
        /// Get bytes from String.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] GetBytesFromString(string text) => Encoding.ASCII.GetBytes(text);

        /// <summary>
        /// Get Stream from underlying text.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Stream GetStreamFromText(string text) => new MemoryStream(GetBytesFromString(text));
    }
}
