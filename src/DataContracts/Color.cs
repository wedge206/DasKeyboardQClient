namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// A Color Object
    /// </summary>
    [JsonObject]
    public class Color
    {
        /// <summary>
        /// Color Code
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Code { get; set; }

        /// <summary>
        /// Color Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
