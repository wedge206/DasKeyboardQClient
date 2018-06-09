namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract]
    public class Color
    {
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Code { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
    }
}
