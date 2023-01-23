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
    public class ReplyRepository : IReplyRepository
    {
        private readonly ChatApplicationContext _ctx;
        public ReplyRepository(ChatApplicationContext ctx)
        {
            _ctx = ctx;
        }

        public Task<Reply> CreateReplyAsync(Reply reply)
        {
            throw new NotImplementedException();
        }

        public Task DeleteReplyAsync(Reply reply)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reply>> GetAllRepliesForMessageAsync(Guid messageId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reply>> GetAllRepliesForUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Reply> GetReplyByIdAsync(Guid replyId)
        {
            throw new NotImplementedException();
        }

        public Task<Reply> UpdateReplyAsync(Reply reply)
        {
            throw new NotImplementedException();
        }
    }
}
