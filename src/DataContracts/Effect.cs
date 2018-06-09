namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Effect
    {
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }
    }
}
