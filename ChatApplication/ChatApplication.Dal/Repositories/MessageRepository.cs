using ChatApplication.Dal.NewFolder;
using ChatApplication.Domain.DTOs;
using ChatApplication.Domain.Entities;
using ChatApplication.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> CheckIfMessageExistsAsync(Guid messageId)
        {
            return await _ctx.Messages.AnyAsync(x => x.Id.Equals(messageId));
        }

        public async Task<Message> CreateMessageAsync(Message message)
        {
            _ctx.Messages.Add(message);
            await _ctx.SaveChangesAsync();
            return message;
        }

        public async Task DeleteMessageAsync(Message message)
        {
            _ctx.Messages.Remove(message);
            await _ctx.SaveChangesAsync();
        }

        public async Task<List<Message>> GetAllMessagesForUserAsync(Guid userId)
        {
            return await _ctx.Messages.Where(x => x.UserId.Equals(userId)).ToListAsync();
        }

        public async Task<Message?> GetMessageByIdAsync(Guid messageId)
        {
            return await _ctx.Messages.FirstOrDefaultAsync(x => x.Id.Equals(messageId));
        }

        public async Task<Message> UpdateMessageAsync(Guid messageId, MessageUpdateDTO message)
        {
            var messageToUpdate = await GetMessageByIdAsync(messageId);
            messageToUpdate.Text = message.Text;
            messageToUpdate.LastEditDate = DateTime.UtcNow;

            await _ctx.SaveChangesAsync();

            return messageToUpdate;
        }
    }
}
