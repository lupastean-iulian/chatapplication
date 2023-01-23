using ChatApplication.Dal.NewFolder;
using ChatApplication.Domain.Entities;
using ChatApplication.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Dal.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly ChatApplicationContext _ctx;
        public MessageRepository(ChatApplicationContext ctx)
        {
            _ctx = ctx;
        }

        public Task<bool> CheckIfMessageExistsAsync(Guid messageId)
        {
            throw new NotImplementedException();
        }

        public Task<Message> CreateMessageAsync(Message message)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMessageAsync(Message message)
        {
            throw new NotImplementedException();
        }

        public Task<List<Message>> GetAllMessagesForUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetMessageByIdAsync(Guid messageId)
        {
            throw new NotImplementedException();
        }

        public Task<Message> UpdateMessageAsync(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
