namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class DeviceDefinition
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "vid", EmitDefaultValue = false)]
        public string Vid { get; set; }

        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        [DataMember(Name = "modelNumber", EmitDefaultValue = false)]
        public string ModelNumber { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "zones", EmitDefaultValue = false)]
        public List<Zone> Zones { get; set; }
    }
}
