using ChatApplication.Domain.Entities;
using ChatApplication.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Application.Replies.Queries
{
    public class GetAllRepliesForUserQuery : IRequest<List<Reply>>
    {
        public Guid UserId { get; set; }
    }
    public class GetAllRepliesForUserQueryHandler : IRequestHandler<GetAllRepliesForUserQuery, List<Reply>>
    {
        private readonly IReplyRepository _replyRepository;
        public GetAllRepliesForUserQueryHandler(IReplyRepository replyRepository)
        {
            _replyRepository = replyRepository;
        }

        public async Task<List<Reply>> Handle(GetAllRepliesForUserQuery request, CancellationToken cancellationToken)
        {
            return await _replyRepository.GetAllRepliesForUserAsync(request.UserId);
        }
    }
}
