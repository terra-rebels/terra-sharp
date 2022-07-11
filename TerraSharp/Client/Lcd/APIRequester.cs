using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TerraSharp.Globals.Exceptions;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TerraSharp.Client.Lcd
{
    class APIParams<T>
    {
        private Dictionary<string, T?> _params { get; set; }

        public APIParams(string key, T? type)
        {
            if (type == null || type.GetType() == typeof(string) || type.GetType() == typeof(double))
            {
                _params = new Dictionary<string, T?>();
                _params.Add(key, type);
            }
            else throw APIParamsTypeInvalidException;
        }

        public Dictionary<string, T?> getParams() => _params;
        public void addParams(string key, T? type) => _params.Add(key, type);
        public T? getParamsByKey(string key) => _params[key];
    }

    public class PaginationOptions
    {
        private string paginationLimit { get; set; }
        private string paginationOffset { get; set; }
        private string paginationKey { get; set; }
        private bool paginationCountTotal { get; set; }
        private bool paginationReverse { get; set; }

        public PaginationOptions(string limit, string offset, string key, bool countTotal, bool reverse)
        {
            paginationLimit = limit;
            paginationOffset = offset;
            paginationKey = key;
            paginationCountTotal = countTotal;
            paginationReverse = reverse;
        }

        public string getPaginationLimit() => paginationLimit;
        public string getPaginationOffset() => paginationOffset;
        public string getPaginationKey() => paginationKey;
        public bool getPaginationCountTotal() => paginationCountTotal;
        public bool getPaginationReverse() => paginationReverse;
    }
    
    public class APIRequester
    {
        private HttpClient APIRequesterHttpClient { get; set; }
        private static string? baseURL;

        public APIRequester(string url)
        {
            baseURL = url;
            APIRequesterHttpClient = new HttpClient();
            APIRequesterHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            APIRequesterHttpClient.Timeout = TimeSpan.FromMilliseconds(30000);
        }

        //private string computeEndpoint: Auxiallary function that computes the direct URI endpoint.
        //This is only used internally by the get and post functions, and is not to be called elsewhere
        //
        //Param 1: string endpoint - The Endpoint Base URL
        private string computeEndpoint(string endpoint)
        {
            var url = new Uri(baseURL); 
            return url.AbsolutePath == "/" ? endpoint : (url.AbsolutePath + endpoint);
        }

        //public async Task<TaskCompletionSource<string>> getRaw: gets raw data from the specifed client address
        //and returns promised completion. 
        //Direct promises are not handled the same way as Javascript/TypeScript, so instead, we have it return
        //a TaskCompletionSource<string>, which is the best analogue in this scenario
        //
        //Param 1: string endpoint - The Endpoint Base URL
        //Param 2: PaginationOptions popts - The Pagination Data for the fetch request
        //
        //Pagination Options are not used here, but should be
        //
        //TODO: Fix and add Pagination Options
        public async Task<TaskCompletionSource<string>> getRaw(string endpoint, PaginationOptions popts)
        {
            var url = computeEndpoint(endpoint);
            TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
            await Task.Run(() => tcs.SetResult(APIRequesterHttpClient.GetAsync(url).Result.Content.ToString()));
            return tcs;

        }

        //public async Task<TaskCompletionSource<string>> post<T>: posts raw data to the specifed client address
        //and returns promised completion. 
        //Direct promises are not handled the same way as Javascript/TypeScript, so instead, we have it return
        //a TaskCompletionSource<string>, which is the best analogue
        //
        //Param 1: string endpoint - The Endpoint Base URL
        //Param 2: T? Data - The data to be sent, which can be anything.
        //
        //Data can be NULL. This is fine as PostAsync can handle  nulled content data, but it 
        //throws a warning when generating string content. This can geneally be ignored, as you can't
        //assign nullable to var. 
        //
        //This fuction and postRaw<T> are identical, so they have been merged to save spae and execution time.
        public async Task<TaskCompletionSource<string>> post<T>(string endpoint,T? data )
        {
            var url = computeEndpoint(endpoint);
            var content = new StringContent(data.ToString() ?? "");
            TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
            await Task.Run(() => tcs.SetResult(APIRequesterHttpClient.PostAsync(url, content).Result.ToString()));
            return tcs;
        }
    }
}
