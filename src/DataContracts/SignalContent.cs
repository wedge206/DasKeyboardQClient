namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Signal Content
    /// </summary>
    [JsonObject]
    public class SignalContent
    {
        /// <summary>
        /// Content
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public List<Signal> Content { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }

        /// <summary>
        /// Sort
        /// </summary>
        [JsonProperty(PropertyName = "sort")]
        public string Sort { get; set; }

        /// <summary>
        /// Created At Time
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Zone Id
        /// </summary>
        [JsonProperty(PropertyName = "zoneId")]
        public string ZoneId { get; set; }

        /// <summary>
        /// Has Next Page?
        /// </summary>
        [JsonProperty(PropertyName = "hasNextPage")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// Page
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public int Page { get; set; }

        /// <summary>
        /// Total Elements
        /// </summary>
        [JsonProperty(PropertyName = "totalElements")]
        public int TotalElements { get; set; }

        /// <summary>
        /// Total Pages
        /// </summary>
        [JsonProperty(PropertyName = "totalPages")]
        public int TotalPages { get; set; }
    }
}
