namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Zone
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
    }
}
