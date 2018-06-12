namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// AuthorizedClient for API Access
    /// </summary>
    [DataContract]
    public class AuthorizedClient
    {
        /// <summary>
        /// Name of the Authorized Client
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
    }
}
