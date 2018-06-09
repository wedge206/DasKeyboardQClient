namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class AuthorizedClient
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
    }
}
