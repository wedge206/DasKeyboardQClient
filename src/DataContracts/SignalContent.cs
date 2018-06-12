namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Signal Content
    /// </summary>
    [DataContract]
    public class SignalContent
    {
        /// <summary>
        /// Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public List<Signal> Content { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Sort
        /// </summary>
        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public string Sort { get; set; }

        /// <summary>
        /// Created At Time
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Zone Id
        /// </summary>
        [DataMember(Name = "zoneId", EmitDefaultValue = false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// Has Next Page?
        /// </summary>
        [DataMember(Name = "hasNextPage", EmitDefaultValue = false)]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Total Elements
        /// </summary>
        [DataMember(Name = "totalElements", EmitDefaultValue = false)]
        public int TotalElements { get; set; }

        /// <summary>
        /// Total Pages
        /// </summary>
        [DataMember(Name = "totalPages", EmitDefaultValue = false)]
        public int TotalPages { get; set; }
    }
}
