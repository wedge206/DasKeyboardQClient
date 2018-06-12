namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Effect that can be applied to a Zone
    /// </summary>
    [DataContract]
    public class Effect
    {
        /// <summary>
        /// Effect Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Effect Name
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }
    }
}
