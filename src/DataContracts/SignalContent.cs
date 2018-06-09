namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract]
    public class SignalContent
    {
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public List<Signal> Content { get; set; }

        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; set; }

        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public string Sort { get; set; }

        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "zoneId", EmitDefaultValue = false)]
        public string ZoneId { get; set; }

        [DataMember(Name = "hasNextPage", EmitDefaultValue = false)]
        public bool HasNextPage { get; set; }

        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        [DataMember(Name = "totalElements", EmitDefaultValue = false)]
        public int TotalElements { get; set; }

        [DataMember(Name = "totalPages", EmitDefaultValue = false)]
        public int TotalPages { get; set; }
    }
}
