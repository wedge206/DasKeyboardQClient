namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A Color Object
    /// </summary>
    [DataContract]
    public class Color
    {
        /// <summary>
        /// Color Code
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Color Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
    }
}
