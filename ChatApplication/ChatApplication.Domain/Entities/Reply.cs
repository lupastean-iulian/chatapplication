using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChatApplication.Domain.Entities
{
    public class Reply
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid MessageId { get; set; }
        public string? Text { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEditDate { get; set; }
#nullable enable
        [JsonIgnore]
        public UserProfile? UserProfile { get; set; }
        [JsonIgnore]
        public Message? Message { get; set; }
#nullable disable
    }
}
