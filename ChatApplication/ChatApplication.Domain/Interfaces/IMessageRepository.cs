using ChatApplication.Domain.DTOs;
using ChatApplication.Domain.Entities;

namespace ChatApplication.Domain.Interfaces
{
    public interface IMessageRepository
    {
        Task<Message> CreateMessageAsync(Message message);
        Task<Message> UpdateMessageAsync(Guid messageId, MessageUpdateDTO message);
        Task DeleteMessageAsync(Message message);
        Task<Message?> GetMessageByIdAsync(Guid messageId);
        Task<List<Message>> GetAllMessagesForUserAsync(Guid userId);
        Task<bool> CheckIfMessageExistsAsync(Guid messageId);
    }
}
