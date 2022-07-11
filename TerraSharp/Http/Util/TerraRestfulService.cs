using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Serilog;
using System.Net;
using System.Text;
using TerraSharp.Constants;

namespace TerraSharp.Http.Util
{
    /// <inheritdoc/>
    public class TerraRestfulService
    {
        private JsonSerializerSettings serializerSettings;
        private readonly TerraHttpClientService clientService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestfulService"/> class.
        /// </summary>
        public TerraRestfulService(
            TerraHttpClientService clientService) //HttpClient comes from the client that consumes it
        {
            this.clientService = clientService;

            this.PrepareConverters();
        }

        private void PrepareConverters()
        {
            this.serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
            };

            this.serializerSettings.Converters.Add(new StringEnumConverter());
            JsonConvert.DefaultSettings = () => this.serializerSettings;
        }

        /// <summary>
        /// Retrieve information.
        /// </summary>
        /// <typeparam name="TResult">Type we are expecting from result.</typeparam>
        /// <param name="uri">Uri to make request to.</param>
        /// <returns>Returns the result.</returns>
        public async Task<byte[]> GetArrayAsync(string uri, CancellationTokenSource tokenSource = null)
        {
            // Attempt to retrieve the data upon successful token
            using (HttpResponseMessage response = await this.clientService.GetAsync(uri, tokenSource))
            {
                response.EnsureSuccessStatusCode();
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidDataException("Could not find stream for specified request");
                }

                return await response.Content.ReadAsByteArrayAsync();
            }
        }

        /// <summary>
        /// Runs a GET operation via HttpClient to retrieve information.
        /// </summary>
        /// <typeparam name="TResult">Type we are expecting from result.</typeparam>
        /// <param name="uri">Uri to make request to.</param>
        /// <returns>Returns the result.</returns>
        public async Task<TerraRestfulResponse<TResult>> GetAsync<TResult>(string uri, CancellationTokenSource tokenSource = null)
        {
            // Attempt to retrieve the data upon successful token
            using (HttpResponseMessage response = await this.clientService.GetAsync(uri, tokenSource))
            {
                response.EnsureSuccessStatusCode();
                if (!response.IsSuccessStatusCode)
                {
                    return new TerraRestfulResponse<TResult>
                    {
                        Successful = false,
                        Message = $"Status Code: {response.StatusCode}, Reason: {response.ReasonPhrase}",
                    };
                }

                return await this.DeserializeResponse<TResult>(response);
            }
        }

        /// <summary>
        /// Runs a POST operation via HttpClient to send information.
        /// </summary>
        /// <typeparam name="T">Type of object data we are sending.</typeparam>
        /// <param name="endpoint">API Endpoint.</param>
        /// <param name="data">Data to send.</param>
        /// <param name="header">Additional header information.</param>
        /// <returns>Rest Response.</returns>
        public async Task<TerraRestfulResponse<T>> PostAsync<T>(string endpoint, T data, CancellationTokenSource tokenSource = null)
        {
            return await this.PostAsync<T, T>(endpoint, data, tokenSource);
        }

        /// <summary>
        /// Runs a POST operation via HttpClient to send information.
        /// </summary>
        /// <typeparam name="TSend">Type of object data we are sending.</typeparam>
        /// <typeparam name="TReceive">Type we expect to receive from response.</typeparam>
        /// <param name="endpoint">Api Endpoint.</param>
        /// <param name="data">Data to send.</param>
        /// <param name="header">Additional header information.</param>
        /// <returns>Response from API.</returns>
        public async Task<TerraRestfulResponse<TReceive>> PostAsync<TSend, TReceive>(string endpoint, TSend data, CancellationTokenSource tokenSource = null)
        {
            if (data != null)
            {
                return await this.UploadDataViaPost<TReceive>(endpoint, new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, Mimes.JSON), tokenSource);
            }
            else
            {
                throw new NullReferenceException("Could not upload payload to Terra for processing. Data is null");
            }
        }

        private async Task<TerraRestfulResponse<TReceive>> UploadDataViaPost<TReceive>(string endpoint, HttpContent payloadContent, CancellationTokenSource tokenSource = null)
        {
            using (HttpResponseMessage response = await this.clientService.PostAsync(endpoint, payloadContent, tokenSource))
            {
                response.EnsureSuccessStatusCode();
                if (!response.IsSuccessStatusCode)
                {
                    return new TerraRestfulResponse<TReceive>
                    {
                        Successful = false,
                        Message = $"Status Code: {response.StatusCode}, Reason: {response.ReasonPhrase}",
                    };
                }

                return await this.DeserializeResponse<TReceive>(response);
            }
        }

        /// <summary>
        /// Runs a PUT operation via HttpClient to send and update information.
        /// </summary>
        /// <typeparam name="TSend">Type of object data we are sending/updating.</typeparam>
        /// <typeparam name="TReceive">Type we expect to receive from response.</typeparam>
        /// <param name="endpoint">API Endpoint.</param>
        /// <param name="data">Data to send and update.</param>
        /// <param name="header">Additional header information.</param>
        /// <returns>Rest Response.</returns>
        public async Task<TerraRestfulResponse<T>> PutAsync<T>(string endpoint, T data, CancellationTokenSource tokenSource = null)
        {
            return await this.PutAsync<T, T>(endpoint, data, tokenSource);
        }

        /// <summary>
        /// Runs a PUT operation via HttpClient to send and update information.
        /// </summary>
        /// <typeparam name="TSend">Type of object data we are sending/updating.</typeparam>
        /// <typeparam name="TReceive">Type we expect to receive from response.</typeparam>
        /// <param name="endpoint">API Endpoint.</param>
        /// <param name="data">Data to send and update.</param>
        /// <param name="header">Additional header information.</param>
        /// <returns>Rest Response.</returns>
        public async Task<TerraRestfulResponse<TReceive>> PutAsync<TSend, TReceive>(string endpoint, TSend data, CancellationTokenSource tokenSource = null)
        {
            using (HttpResponseMessage response = await this.clientService.PutAsync(endpoint, new StringContent(JsonConvert.SerializeObject(data)), tokenSource))
            {
                response.EnsureSuccessStatusCode();
                if (!response.IsSuccessStatusCode)
                {
                    return new TerraRestfulResponse<TReceive>
                    {
                        Successful = false,
                        Message = $"Status Code: {response.StatusCode}, Reason: {response.ReasonPhrase}",
                    };
                }

                return await this.DeserializeResponse<TReceive>(response);
            }
        }

        /// <summary>
        /// Runs a DELETE operation via HttpClient to delete information.
        /// </summary>
        /// <param name="uri">Uri to make request to.</param>
        /// <returns>Returns result.</returns>
        public virtual async Task<TerraRestfulResponse<bool>> DeleteAsync(string uri, CancellationTokenSource tokenSource = null)
        {
            using (HttpResponseMessage response = await this.clientService.DeleteAsync(uri, tokenSource))
            {
                response.EnsureSuccessStatusCode();
                if (!response.IsSuccessStatusCode)
                {
                    return new TerraRestfulResponse<bool>
                    {
                        Result = false,
                        Successful = false,
                        Message = $"Status Code: {response.StatusCode}, Reason: {response.ReasonPhrase}",
                    };
                }
            }

            return new TerraRestfulResponse<bool>
            {
                Successful = true,
                Result = true,
            };
        }

        private async Task<TerraRestfulResponse<TResult>> DeserializeResponse<TResult>(HttpResponseMessage responseMessage)
        {
            try
            {
                var message = await responseMessage.Content.ReadAsStringAsync();

                TResult result = JsonConvert.DeserializeObject<TResult>(await responseMessage.Content.ReadAsStringAsync());
                return new TerraRestfulResponse<TResult>
                {
                    Successful = true,
                    Result = result,
                };
            }
            catch (JsonReaderException e)
            {
                // If we are unable to deserialize, notify of failed attempt
                return new TerraRestfulResponse<TResult>
                {
                    Successful = false,
                    Message = e.Message,
                };
            }
        }

        //inheritDoc
        public void ForceDisconnectHttpClient()
        {
       //     this.htt.ForceDisconnectAllClients();
        }

        public void PrepareHttpClientFromConsumer(HttpClient httpClient)
        {
            this.clientService.PrepareHttpClient(httpClient);
        }

        public async Task<bool> VerifyRemoteResource(string baseAddress)
        {
            HttpWebRequest request = WebRequest.Create(baseAddress) as HttpWebRequest;
            request.Method = "GET";
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                return response.StatusCode == HttpStatusCode.OK;
            }
        }
    }
}
