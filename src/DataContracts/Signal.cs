namespace Wedge.DasKeyboardQClient.DataContracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract]
    public class Signal
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; set; }

        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        [DataMember(Name = "zoneId", EmitDefaultValue = false)]
        public string ZoneId { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        [DataMember(Name = "effect", EmitDefaultValue = false)]
        public string Effect { get; set; }

        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        [DataMember(Name = "isread", EmitDefaultValue = false)]
        public bool IsRead { get; set; }

        [DataMember(Name = "ismuted", EmitDefaultValue = false)]
        public bool IsMuted { get; set; }

        [DataMember(Name = "isArchived", EmitDefaultValue = false)]
        public bool IsArchived { get; set; }

        [DataMember(Name = "shouldNotify", EmitDefaultValue = false)]
        public bool ShouldNotify { get; set; }

        [DataMember(Name = "clientName", EmitDefaultValue = false)]
        public string ClientName { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        [DataMember(Name = "readAt", EmitDefaultValue = false)]
        public DateTime ReadAt { get; set; }

        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }
    }
}
