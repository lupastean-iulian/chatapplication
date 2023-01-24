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
    public class ReplyRepository : IReplyRepository
    {
        private readonly ChatApplicationContext _ctx;
        public ReplyRepository(ChatApplicationContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Reply> CreateReplyAsync(Reply reply)
        {
            _ctx.Replies.Add(reply);
            await _ctx.SaveChangesAsync();
            return reply;
        }

        public async Task DeleteReplyAsync(Reply reply)
        {
            _ctx.Replies.Remove(reply);
            await _ctx.SaveChangesAsync();
        }

        public async Task<List<Reply>> GetAllRepliesForMessageAsync(Guid messageId)
        {
            return await _ctx.Replies.Where(x => x.MessageId.Equals(messageId)).AsNoTracking().ToListAsync();
        }

        public async Task<List<Reply>> GetAllRepliesForUserAsync(Guid userId)
        {
            return await _ctx.Replies.Where(x => x.UserId.Equals(userId)).AsNoTracking().ToListAsync();
        }

        public async Task<Reply?> GetReplyByIdAsync(Guid replyId)
        {
            return await _ctx.Replies.FirstOrDefaultAsync(x => x.Id.Equals(replyId));
        }

        public async Task<Reply> UpdateReplyAsync(Guid replyId, ReplyUpdateDTO reply)
        {
            var replyToUpdate = await GetReplyByIdAsync(replyId);
            replyToUpdate.Text = reply.Text;
            replyToUpdate.LastEditDate = DateTime.UtcNow;

            await _ctx.SaveChangesAsync();

            return replyToUpdate;
        }
    }
}
