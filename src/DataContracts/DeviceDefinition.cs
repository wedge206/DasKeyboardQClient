namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Device Definition
    /// </summary>
    [JsonObject]
    public class DeviceDefinition
    {
        /// <summary>
        /// Name of the Device Definition
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// VID of the Device Definition
        /// </summary>
        [JsonProperty(PropertyName = "vid")]
        public string Vid { get; set; }

        /// <summary>
        /// Product Id of the Device Definition
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public string Pid { get; set; }

        /// <summary>
        /// Model Number of the Device Definition
        /// </summary>
        [JsonProperty(PropertyName = "modelNumber")]
        public string ModelNumber { get; set; }

        /// <summary>
        /// Device Definition Description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Zones for the Device Definition
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public List<Zone> Zones { get; set; }
    }
}
