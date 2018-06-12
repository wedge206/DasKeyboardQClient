namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// AuthorizedClient for API Access
    /// </summary>
    [JsonObject]
    public class AuthorizedClient
    {
        /// <summary>
        /// Name of the Authorized Client
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
