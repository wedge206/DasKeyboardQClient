namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Q Enabled Device
    /// </summary>
    [JsonObject]
    public class Device
    {
        /// <summary>
        /// Unique Id of the Device
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// UserId that owns the Device
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Product Id of the Device
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public string Pid { get; set; }

        /// <summary>
        /// Firmware version of the Device
        /// </summary>
        [JsonProperty(PropertyName = "firmwareVersion")]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// VID of the Device
        /// </summary>
        [JsonProperty(PropertyName = "vid")]
        public string Vid { get; set; }

        /// <summary>
        /// Description of the Device
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Zones on the Devices
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public List<Zone> Zones { get; set; }
    }
}
