namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Base class for QClients
    /// </summary>
    public abstract class QClient : IQClient, IDisposable
    {
        private const string ApiPath = "api/1.0";

        /// <summary>
        /// Base URL for all API Requests
        /// </summary>
        protected string Url { get; set; }

        /// <summary>
        /// Initialize a new QClient
        /// </summary>
        /// <param name="hostPath">Base URL for all api requests</param>
        protected QClient(string hostPath)
        {
            Url = $"{hostPath}/{ApiPath}";
        }

        /// <summary>
        /// Executes HTTP GET Request
        /// </summary>
        /// <param name="path">Path of the request</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns>Async Task</returns>
        protected async Task<HttpResponseMessage> HttpGetAsync(string path, HttpMessageHandler tokenHandler = null)
        {
            using (var client = tokenHandler == null ? new HttpClient() : new HttpClient(tokenHandler))
            {
                var result = await client.GetAsync($"{Url}/{path}");
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        /// <summary>
        /// Executes an HTTP GET Request
        /// </summary>
        /// <typeparam name="T">Type of the return object</typeparam>
        /// <param name="path">Path of the Request</param>
        /// <param name="tokenHandler">(Optional) Authentication Token handler</param>
        /// <returns></returns>
        protected async Task<T> HttpGetAsync<T>(string path, HttpMessageHandler tokenHandler = null)
        {
            var result = await HttpGetAsync(path, tokenHandler);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        /// <summary>
        /// Executes an HTTP POST Request
        /// </summary>
        /// <param name="path">Path of the Request</param>
        /// <param name="postContent">Content of the POST body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns>Async Task</returns>
        protected async Task<HttpResponseMessage> HttpPostAsync(string path, string postContent, HttpMessageHandler tokenHandler = null)
        {
            using (var client = tokenHandler == null ? new HttpClient() : new HttpClient(tokenHandler))
            {
                var result = await client.PostAsync($"{Url}/{path}", new StringContent(postContent, Encoding.UTF8, "application/json"));
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        /// <summary>
        /// Executes an HTTP POST Request
        /// </summary>
        /// <typeparam name="T">Object Type</typeparam>
        /// <param name="path">Path of the request</param>
        /// <param name="postContent">Content of the POST body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns></returns>
        protected async Task<T> HttpPostAsync<T>(string path, string postContent, HttpMessageHandler tokenHandler = null)
        {
            var result = await HttpPostAsync(path, postContent, tokenHandler);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        /// <summary>
        /// Executes an HTTP PATCH Request
        /// </summary>
        /// <param name="path">Path of the request</param>
        /// <param name="patchContent">Content of the PATCH body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns></returns>
        protected async Task<HttpResponseMessage> HttpPatchAsync(string path, string patchContent, HttpMessageHandler tokenHandler = null)
        {
            using (var client = tokenHandler == null ? new HttpClient() : new HttpClient(tokenHandler))
            {
                var result = await client.PatchAsync($"{Url}/{path}", new StringContent(patchContent, Encoding.UTF8, "application/json"));
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        /// <summary>
        /// Executes an HTTP PATCH Request
        /// </summary>
        /// <typeparam name="T">Object Type</typeparam>
        /// <param name="path">Path of the request</param>
        /// <param name="patchContent">Content of the PATCH body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns></returns>
        protected async Task<T> HttpPatchAsync<T>(string path, string patchContent, HttpMessageHandler tokenHandler = null)
        {
            var result = await HttpPatchAsync(path, patchContent, tokenHandler);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        /// <summary>
        /// Executes an HTTP PUT Request
        /// </summary>
        /// <param name="path">Path of the request</param>
        /// <param name="putContent">Content of the PUT body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns></returns>
        protected async Task<HttpResponseMessage> HttpPutAsync(string path, string putContent, HttpMessageHandler tokenHandler = null)
        {
            using (var client = tokenHandler == null ? new HttpClient() : new HttpClient(tokenHandler))
            {
                var result = await client.PutAsync($"{Url}/{path}", new StringContent(putContent, Encoding.UTF8, "application/json"));
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        /// <summary>
        /// Executes an HTTP PUT Request
        /// </summary>
        /// <typeparam name="T">Object Type</typeparam>
        /// <param name="path">Path of the request</param>
        /// <param name="putContent">Content of the PUT body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns></returns>
        protected async Task<T> HttpPutAsync<T>(string path, string putContent, HttpMessageHandler tokenHandler = null)
        {
            var result = await HttpPutAsync(path, putContent, tokenHandler);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        /// <summary>
        /// Executes an HTTP DELETE Request
        /// </summary>
        /// <param name="path">Path of the Request</param>
        /// <param name="tokenHandler">Authentication Token Handler</param>
        /// <returns>Async Task</returns>
        protected async Task<HttpResponseMessage> HttpDeleteAsync(string path, HttpMessageHandler tokenHandler = null)
        {
            using (var client = tokenHandler == null ? new HttpClient() : new HttpClient(tokenHandler))
            {
                var result = await client.DeleteAsync($"{Url}/{path}");
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        /// <summary>
        /// Executes an HTTP DELETE Request
        /// </summary>
        /// <typeparam name="T">Type of the return value</typeparam>
        /// <param name="path">Path of the Request</param>
        /// <param name="tokenHandler">Authentication Token Handler</param>
        /// <returns>Object of type T</returns>
        protected async Task<T> HttpDeleteAsync<T>(string path, HttpMessageHandler tokenHandler = null)
        {
            var result = await HttpDeleteAsync(path, tokenHandler);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        private bool disposedValue = false;

        /// <summary>
        /// Dispose this object
        /// </summary>
        /// <param name="disposing">Prevents duplicate Dispose calls</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                disposedValue = true;
            }
        }

        /// <summary>
        /// Dispose this object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }
    }
}
