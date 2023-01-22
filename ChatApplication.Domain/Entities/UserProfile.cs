using System.ComponentModel.DataAnnotations;

namespace ChatApplication.Domain.Entities
{
    public class UserProfile
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
#nullable enable
        public ICollection<Message>? Messages { get; set; }
        public ICollection<Reply>? Replies { get; set; }
#nullable disable

    }
}
