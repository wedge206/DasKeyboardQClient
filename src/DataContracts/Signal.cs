namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Signal Class
    /// </summary>
    [DataContract]
    public class Signal
    {
        /// <summary>
        /// Unique Id of the Signal
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// UserId for the Signal
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Product Id
        /// </summary>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// Zone Id
        /// </summary>
        [DataMember(Name = "zoneId", EmitDefaultValue = false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// Name of the Signal
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// Effect
        /// </summary>
        [DataMember(Name = "effect", EmitDefaultValue = false)]
        public string Effect { get; set; }

        /// <summary>
        /// Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Is Read?
        /// </summary>
        [DataMember(Name = "isread", EmitDefaultValue = false)]
        public bool IsRead { get; set; }

        /// <summary>
        /// Is Muted?
        /// </summary>
        [DataMember(Name = "ismuted", EmitDefaultValue = false)]
        public bool IsMuted { get; set; }

        /// <summary>
        /// Is Archived?
        /// </summary>
        [DataMember(Name = "isArchived", EmitDefaultValue = false)]
        public bool IsArchived { get; set; }

        /// <summary>
        /// Should Notify?
        /// </summary>
        [DataMember(Name = "shouldNotify", EmitDefaultValue = false)]
        public bool ShouldNotify { get; set; }

        /// <summary>
        /// Client Name
        /// </summary>
        [DataMember(Name = "clientName", EmitDefaultValue = false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Read At Time
        /// </summary>
        [DataMember(Name = "readAt", EmitDefaultValue = false)]
        public DateTime ReadAt { get; set; }

        /// <summary>
        /// Created at Time
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updated At Time
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }
    }
}
