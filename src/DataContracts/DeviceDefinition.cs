namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Device Definition
    /// </summary>
    [DataContract]
    public class DeviceDefinition
    {
        /// <summary>
        /// Name of the Device Definition
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// VID of the Device Definition
        /// </summary>
        [DataMember(Name = "vid", EmitDefaultValue = false)]
        public string Vid { get; set; }

        /// <summary>
        /// Product Id of the Device Definition
        /// </summary>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// Model Number of the Device Definition
        /// </summary>
        [DataMember(Name = "modelNumber", EmitDefaultValue = false)]
        public string ModelNumber { get; set; }

        /// <summary>
        /// Device Definition Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Zones for the Device Definition
        /// </summary>
        [DataMember(Name = "zones", EmitDefaultValue = false)]
        public List<Zone> Zones { get; set; }
    }
}
