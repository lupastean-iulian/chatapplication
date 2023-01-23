using ChatApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Domain.Interfaces
{
    public interface IMessageRepository
    {
        Task<Message> CreateMessageAsync(Message message);
        Task<Message> UpdateMessageAsync(Message message);
        Task DeleteMessageAsync(Message message);
        Task<Message> GetMessageByIdAsync(Guid messageId);
        Task<List<Message>> GetAllMessagesForUserAsync(Guid userId);
        Task<bool> CheckIfMessageExistsAsync(Guid messageId);
    }
}
