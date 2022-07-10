using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TerraSharp.Constants;

namespace TerraSharp.Http.Util
{
    public class TerraHttpClientService : IDisposable
    {
        private TimeSpan httpClientTimeout;
        public HttpClient httpClient;

        public void PrepareHttpClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.httpClientTimeout = TimeSpan.FromSeconds(HttpBehaviourConstants.DefaultHttpTimeoutSeconds); // Default Timeout

            // Add all default Headers
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Mimes.JSON));
            this.httpClient.DefaultRequestHeaders.ExpectContinue = false;
        }

        private async Task<HttpResponseMessage> RunHttpOperation(Func<CancellationTokenSource, Task<HttpResponseMessage>> runOperation,
            CancellationTokenSource upperToken = null)
        {
            if (upperToken != null)
            {
                if (!upperToken.IsCancellationRequested)
                {
                    upperToken.CancelAfter((int)this.httpClientTimeout.TotalMilliseconds);
                    using (upperToken)
                    {
                        return await runOperation(upperToken);
                    }
                }
            }
            else
            {
                using (var tokenSource = new CancellationTokenSource(this.httpClientTimeout))
                {
                    return await runOperation(tokenSource);
                }
            }

            throw new TaskCanceledException("Cancellation Requested for task");
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationTokenSource upperToken = null)
        {
            return await this.RunHttpOperation((source) => this.httpClient.DeleteAsync(requestUri, source.Token), upperToken);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> GetAsync(string requestUri, CancellationTokenSource upperToken = null)
        {
            return await this.RunHttpOperation((source) => this.httpClient.GetAsync(requestUri,
                HttpCompletionOption.ResponseContentRead, source.Token), upperToken);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationTokenSource upperToken = null)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, new Uri(requestUri)))
            {
                request.Content = content;

                return await this.RunHttpOperation((source) => this.httpClient.SendAsync(request,
                    HttpCompletionOption.ResponseContentRead, source.Token), upperToken);
            }
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationTokenSource upperToken = null)
        {
            return await this.RunHttpOperation((source) => this.httpClient.PutAsync(requestUri, content, source.Token), upperToken);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.httpClient != null)
                {
                    this.httpClient.Dispose();
                }
            }
        }

        public void ForceDisconnectAllClients()
        {
            this.httpClient.CancelPendingRequests();
        }
    } }
