namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Effect that can be applied to a Zone
    /// </summary>
    [JsonObject]
    public class Effect
    {
        /// <summary>
        /// Effect Code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Effect Name
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
    }
}
