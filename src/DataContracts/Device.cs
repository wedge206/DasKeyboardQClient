namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    [DataContract]
    public class Device
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; set; }

        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        [DataMember(Name = "firmwareVersion", EmitDefaultValue = false)]
        public string FirmwareVersion { get; set; }

        [DataMember(Name = "vid", EmitDefaultValue = false)]
        public string Vid { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "zones", EmitDefaultValue = false)]
        public List<Zone> Zones { get; set; }
    }
}
