namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    /// Extension Methods
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Parse a JSON String
        /// </summary>
        /// <typeparam name="T">Type of the Object</typeparam>
        /// <param name="jsonString">JSON Object</param>
        /// <returns>Parsed Object of type T</returns>
        public static T ParseJSON<T>(this string jsonString)
        {
            if (String.IsNullOrWhiteSpace(jsonString))
            {
                return default(T);
            }

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        /// <summary>
        /// TryParse a JSON String
        /// </summary>
        /// <typeparam name="T">Type of the Object</typeparam>
        /// <param name="jsonString">JSON Object</param>
        /// <param name="obj">Parsed Object of type T</param>
        /// <returns>True if success</returns>
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

        /// <summary>
        /// Serializes any object to a JSON String
        /// </summary>
        /// <param name="obj">Object to be serialized</param>
        /// <returns>JSON String of the Object</returns>
        public static string ToJSON(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// Executes a PATCH request
        /// </summary>
        /// <param name="client">HttpClient object</param>
        /// <param name="requestUri">Uri of the request</param>
        /// <param name="content">Content to be Patched</param>
        /// <returns>Async Task</returns>
        public static async Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent content)
        {
            if (Uri.TryCreate(requestUri, UriKind.RelativeOrAbsolute, out var uri))
            {
                return await client.PatchAsync(uri, content);
            }

            throw new UriFormatException($"{nameof(requestUri)} is not a valid URL");
        }

        /// <summary>
        /// Executes a PATCH request
        /// </summary>
        /// <param name="client">HttpClient object</param>
        /// <param name="requestUri">Uri of the request</param>
        /// <param name="content">Content to be Patched</param>
        /// <returns>Async Task</returns>
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
