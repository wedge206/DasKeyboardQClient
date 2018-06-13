namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// IQClient
    /// </summary>
    public interface IQClient
    {
        /// <summary>
        /// Executes HTTP GET Request
        /// </summary>
        /// <param name="path">Path of the request</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns>Async Task</returns>
        Task<HttpResponseMessage> HttpGetAsync(string path, HttpMessageHandler tokenHandler = null);

        /// <summary>
        /// Executes an HTTP GET Request
        /// </summary>
        /// <typeparam name="T">Type of the return object</typeparam>
        /// <param name="path">Path of the Request</param>
        /// <param name="tokenHandler">(Optional) Authentication Token handler</param>
        /// <returns></returns>
        Task<T> HttpGetAsync<T>(string path, HttpMessageHandler tokenHandler = null);

        /// <summary>
        /// Executes an HTTP POST Request
        /// </summary>
        /// <param name="path">Path of the Request</param>
        /// <param name="postContent">Content of the POST body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns>Async Task</returns>
        Task<HttpResponseMessage> HttpPostAsync(string path, string postContent, HttpMessageHandler tokenHandler = null);

        /// <summary>
        /// Executes an HTTP POST Request
        /// </summary>
        /// <typeparam name="T">Object Type</typeparam>
        /// <param name="path">Path of the request</param>
        /// <param name="postContent">Content of the POST body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns></returns>
        Task<T> HttpPostAsync<T>(string path, string postContent, HttpMessageHandler tokenHandler = null);

        /// <summary>
        /// Executes an HTTP PATCH Request
        /// </summary>
        /// <param name="path">Path of the request</param>
        /// <param name="patchContent">Content of the PATCH body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns></returns>
        Task<HttpResponseMessage> HttpPatchAsync(string path, string patchContent, HttpMessageHandler tokenHandler = null);

        /// <summary>
        /// Executes an HTTP PATCH Request
        /// </summary>
        /// <typeparam name="T">Object Type</typeparam>
        /// <param name="path">Path of the request</param>
        /// <param name="patchContent">Content of the PATCH body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns></returns>
        Task<T> HttpPatchAsync<T>(string path, string patchContent, HttpMessageHandler tokenHandler = null);

        /// <summary>
        /// Executes an HTTP PUT Request
        /// </summary>
        /// <param name="path">Path of the request</param>
        /// <param name="putContent">Content of the PUT body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns></returns>
        Task<HttpResponseMessage> HttpPutAsync(string path, string putContent, HttpMessageHandler tokenHandler = null);

        /// <summary>
        /// Executes an HTTP PUT Request
        /// </summary>
        /// <typeparam name="T">Object Type</typeparam>
        /// <param name="path">Path of the request</param>
        /// <param name="putContent">Content of the PUT body</param>
        /// <param name="tokenHandler">(Optional) Authentication Token Handler</param>
        /// <returns></returns>
        Task<T> HttpPutAsync<T>(string path, string putContent, HttpMessageHandler tokenHandler = null);

        /// <summary>
        /// Executes an HTTP DELETE Request
        /// </summary>
        /// <param name="path">Path of the Request</param>
        /// <param name="tokenHandler">Authentication Token Handler</param>
        /// <returns>Async Task</returns>
        Task<HttpResponseMessage> HttpDeleteAsync(string path, HttpMessageHandler tokenHandler = null);

        /// <summary>
        /// Executes an HTTP DELETE Request
        /// </summary>
        /// <typeparam name="T">Type of the return value</typeparam>
        /// <param name="path">Path of the Request</param>
        /// <param name="tokenHandler">Authentication Token Handler</param>
        /// <returns>Object of type T</returns>
        Task<T> HttpDeleteAsync<T>(string path, HttpMessageHandler tokenHandler = null);
    }
}
