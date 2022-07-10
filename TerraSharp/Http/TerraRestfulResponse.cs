namespace TerraSharp.Http
{
    /// <summary>
    /// Class to use to pass responses with data collected from modern httpClient Native.
    /// </summary>
    /// <typeparam name="T">Type we are expecting.</typeparam>
    public class TerraRestfulResponse<T> 
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets whether the request successful.
        /// </summary>
        public bool Successful { get; set; }

        /// <summary>
        /// Gets or sets the Result deserialized into the type we want.
        /// </summary>
        public T Result { get; set; }

        /// <summary>
        /// Gets or sets a message which is populated upon failed requests.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Retrieve the Stream content from the Response.
        /// </summary>
        public byte[] BodyContent { get; set; }
    }
}