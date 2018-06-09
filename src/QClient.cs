namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Wedge.DasKeyboardQClient.DataContracts;

    public abstract class QClient : IQClient
    {
        private const string ApiPath = "api/1.0";

        protected string Url { get; set; }

        protected QClient(string hostPath)
        {
            Url = $"{hostPath}/{ApiPath}";
        }

        protected async Task<HttpResponseMessage> HttpGetAsync(string path, string accessToken = null)
        {
            using (var client = new HttpClient())
            {
                if (accessToken != null)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                }

                var result = await client.GetAsync($"{Url}/{path}");
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        protected async Task<T> HttpGetAsync<T>(string path, string accessToken = null)
        {
            var result = await HttpGetAsync(path, accessToken);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        protected async Task<HttpResponseMessage> HttpPostAsync(string path, string postContent, string accessToken = null)
        {
            using (var client = new HttpClient())
            {
                if (accessToken != null)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                }

                var result = await client.PostAsync($"{Url}/{path}", new StringContent(postContent, Encoding.UTF8, "application/json"));
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        protected async Task<T> HttpPostAsync<T>(string path, string postContent, string accessToken = null)
        {
            var result = await HttpPostAsync(path, postContent, accessToken);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        protected async Task<HttpResponseMessage> HttpPatchAsync(string path, string patchContent, string accessToken = null)
        {
            using (var client = new HttpClient())
            {
                if (accessToken != null)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                }

                var result = await client.PatchAsync($"{Url}/{path}", new StringContent(patchContent, Encoding.UTF8, "application/json"));
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        protected async Task<T> HttpPatchAsync<T>(string path, string patchContent, string accessToken = null)
        {
            var result = await HttpPatchAsync(path, patchContent, accessToken);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        protected async Task<HttpResponseMessage> HttpPutAsync(string path, string putContent, string accessToken = null)
        {
            using (var client = new HttpClient())
            {
                if (accessToken != null)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                }

                var result = await client.PutAsync($"{Url}/{path}", new StringContent(putContent, Encoding.UTF8, "application/json"));
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        protected async Task<T> HttpPutAsync<T>(string path, string putContent, string accessToken = null)
        {
            var result = await HttpPutAsync(path, putContent, accessToken);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        protected async Task<HttpResponseMessage> HttpDeleteAsync(string path, string accessToken = null)
        {
            using (var client = new HttpClient())
            {
                if (accessToken != null)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                }

                var result = await client.DeleteAsync($"{Url}/{path}");
                result.EnsureSuccessStatusCode();

                return result;
            }
        }

        protected async Task<T> HttpDeleteAsync<T>(string path, string accessToken = null)
        {
            var result = await HttpDeleteAsync(path, accessToken);
            var content = await result.Content.ReadAsStringAsync();

            return content.ParseJSON<T>();
        }

        public virtual Task<List<AuthorizedClient>> GetAuthorizedClientsAsync()
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support GetAuthorizedClients()");
        }

        public virtual Task RevokeClientAsync(AuthorizedClient client)
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support RevokeClient()");
        }

        public virtual Task<List<Device>> GetDevicesAsync()
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support GetDevices()");
        }

        public virtual Task<List<DeviceDefinition>> GetDeviceDefinitionsAsync()
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support GetDeviceDefinitions()");
        }

        public virtual Task<List<Color>> GetColorsAsync()
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support GetColors()");
        }

        public virtual Task<List<Zone>> GetZonesAsync(string pid)
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support GetZones()");
        }

        public virtual Task<List<Effect>> GetEffectsAsync(string pid)
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support GetEffects()");
        }

        public virtual Task CreateSignalAsync(Signal signal)
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support CreateSignal()");
        }

        public virtual Task<List<Signal>> GetSignalsAsync(int? afterTime = null)
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support GetSignals()");
        }

        public virtual Task UpdateSignalAsync(string id, Signal signal)
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support UpdateSignal()");
        }

        public virtual Task DeleteSignalAsync(string id)
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support DeleteSignal()");
        }

        public virtual Task<string> GetZoneColorAsync(string pid, string zoneId)
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support GetZoneColor()");
        }

        public virtual Task<List<Signal>> GetDeviceShadowAsync(string pid)
        {
            throw new NotSupportedException($"{this.GetType().Name} does not support GetDeviceShadow()");
        }
    }
}
