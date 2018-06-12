namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Zone
    /// </summary>
    [JsonObject]
    public class Zone
    {
        /// <summary>
        /// Unique Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
