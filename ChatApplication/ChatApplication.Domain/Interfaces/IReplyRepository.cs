using ChatApplication.Domain.DTOs;
using ChatApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Domain.Interfaces
{
    public interface IReplyRepository
    {
        Task<Reply> CreateReplyAsync(Reply reply);
        Task<Reply> UpdateReplyAsync(Guid replyId, ReplyUpdateDTO reply);
        Task DeleteReplyAsync(Reply reply);
        Task<Reply?> GetReplyByIdAsync(Guid replyId);
        Task<List<Reply>> GetAllRepliesForMessageAsync(Guid messageId);
        Task<List<Reply>> GetAllRepliesForUserAsync(Guid userId);

    }
}
