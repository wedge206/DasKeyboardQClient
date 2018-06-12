namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Signal Class
    /// </summary>
    [JsonObject]
    public class Signal
    {
        /// <summary>
        /// Unique Id of the Signal
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// UserId for the Signal
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Product Id
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public string Pid { get; set; }

        /// <summary>
        /// Zone Id
        /// </summary>
        [JsonProperty(PropertyName = "zoneId")]
        public string ZoneId { get; set; }

        /// <summary>
        /// Name of the Signal
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// Effect
        /// </summary>
        [JsonProperty(PropertyName = "effect")]
        public string Effect { get; set; }

        /// <summary>
        /// Action
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Is Read?
        /// </summary>
        [JsonProperty(PropertyName = "isread")]
        public bool IsRead { get; set; }

        /// <summary>
        /// Is Muted?
        /// </summary>
        [JsonProperty(PropertyName = "ismuted")]
        public bool IsMuted { get; set; }

        /// <summary>
        /// Is Archived?
        /// </summary>
        [JsonProperty(PropertyName = "isArchived")]
        public bool IsArchived { get; set; }

        /// <summary>
        /// Should Notify?
        /// </summary>
        [JsonProperty(PropertyName = "shouldNotify")]
        public bool ShouldNotify { get; set; }

        /// <summary>
        /// Client Name
        /// </summary>
        [JsonProperty(PropertyName = "clientName")]
        public string ClientName { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Read At Time
        /// </summary>
        [JsonProperty(PropertyName = "readAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ReadAt { get; set; }

        /// <summary>
        /// Created at Time
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updated At Time
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime UpdatedAt { get; set; }
    }
}
