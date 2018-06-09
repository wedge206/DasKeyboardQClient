namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Runtime.Serialization.Json;
    using System.Text;
    using System.Threading.Tasks;

    public static class Extensions
    {
        public static T ParseJSON<T>(this string jsonString)
        {
            if (String.IsNullOrWhiteSpace(jsonString))
            {
                return default(T);
            }

            var JsonDeserializer = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                return (T)JsonDeserializer.ReadObject(stream);
            }
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
            var JsonSerializer = new DataContractJsonSerializer(obj.GetType());
            using (MemoryStream stream = new MemoryStream())
            {
                JsonSerializer.WriteObject(stream, obj);

                return Encoding.UTF8.GetString(stream.ToArray());
            }
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
