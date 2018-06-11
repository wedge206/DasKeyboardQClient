namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class QClient : IQClient
    {
        private const string ApiPath = "api/1.0";

        protected string Url { get; set; }

        protected QClient(string hostPath)
        {
            Url = $"{hostPath}/{ApiPath}";
        }

        protected async Task<HttpResponseMessage> HttpGetAsync(string path, HttpMessageHandler tokenHandler = null)
        {
            using (var client = tokenHandler == null ? new HttpClient() : new HttpClient(tokenHandler))
            {
                var result = await client.GetAsync($"{Url}/{path}");
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        protected async Task<T> HttpGetAsync<T>(string path, HttpMessageHandler tokenHandler = null)
        {
            var result = await HttpGetAsync(path, tokenHandler);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        protected async Task<HttpResponseMessage> HttpPostAsync(string path, string postContent, HttpMessageHandler tokenHandler = null)
        {
            using (var client = tokenHandler == null ? new HttpClient() : new HttpClient(tokenHandler))
            {
                var result = await client.PostAsync($"{Url}/{path}", new StringContent(postContent, Encoding.UTF8, "application/json"));
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        protected async Task<T> HttpPostAsync<T>(string path, string postContent, HttpMessageHandler tokenHandler = null)
        {
            var result = await HttpPostAsync(path, postContent, tokenHandler);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        protected async Task<HttpResponseMessage> HttpPatchAsync(string path, string patchContent, HttpMessageHandler tokenHandler = null)
        {
            using (var client = tokenHandler == null ? new HttpClient() : new HttpClient(tokenHandler))
            {
                var result = await client.PatchAsync($"{Url}/{path}", new StringContent(patchContent, Encoding.UTF8, "application/json"));
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        protected async Task<T> HttpPatchAsync<T>(string path, string patchContent, HttpMessageHandler tokenHandler = null)
        {
            var result = await HttpPatchAsync(path, patchContent, tokenHandler);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        protected async Task<HttpResponseMessage> HttpPutAsync(string path, string putContent, HttpMessageHandler tokenHandler = null)
        {
            using (var client = tokenHandler == null ? new HttpClient() : new HttpClient(tokenHandler))
            {
                var result = await client.PutAsync($"{Url}/{path}", new StringContent(putContent, Encoding.UTF8, "application/json"));
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        protected async Task<T> HttpPutAsync<T>(string path, string putContent, HttpMessageHandler tokenHandler = null)
        {
            var result = await HttpPutAsync(path, putContent, tokenHandler);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        protected async Task<HttpResponseMessage> HttpDeleteAsync(string path, HttpMessageHandler tokenHandler = null)
        {
            using (var client = tokenHandler == null ? new HttpClient() : new HttpClient(tokenHandler))
            {
                var result = await client.DeleteAsync($"{Url}/{path}");
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        protected async Task<T> HttpDeleteAsync<T>(string path, HttpMessageHandler tokenHandler = null)
        {
            var result = await HttpDeleteAsync(path, tokenHandler);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }
    }
}
