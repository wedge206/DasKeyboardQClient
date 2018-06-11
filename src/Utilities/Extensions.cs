namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public static class Extensions
    {
        public static T ParseJSON<T>(this string jsonString)
        {
            if (String.IsNullOrWhiteSpace(jsonString))
            {
                return default(T);
            }

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public static bool TryParseJSON<T>(this string jsonString, out T obj)
        {
            try
            {
                obj = jsonString.ParseJSON<T>();
                return true;
            }
            catch (InvalidCastException)
            {
                obj = default(T);
                return false;
            }
        }

        public static string ToJSON(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static async Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent content)
        {
            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, requestUri)
            {
                Content = content
            };

            return await client.SendAsync(request);
        }

        public static async Task<HttpResponseMessage> PatchAsync(this HttpClient client, Uri requestUri, HttpContent content)
        {
            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, requestUri)
            {
                Content = content
            };

            return await client.SendAsync(request);
        }
    }
}
