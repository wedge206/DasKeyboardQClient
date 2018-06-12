namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Q Enabled Device
    /// </summary>
    [DataContract]
    public class Device
    {
        /// <summary>
        /// Unique Id of the Device
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// UserId that owns the Device
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Product Id of the Device
        /// </summary>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// Firmware version of the Device
        /// </summary>
        [DataMember(Name = "firmwareVersion", EmitDefaultValue = false)]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// VID of the Device
        /// </summary>
        [DataMember(Name = "vid", EmitDefaultValue = false)]
        public string Vid { get; set; }

        /// <summary>
        /// Description of the Device
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Zones on the Devices
        /// </summary>
        [DataMember(Name = "zones", EmitDefaultValue = false)]
        public List<Zone> Zones { get; set; }
    }
}
