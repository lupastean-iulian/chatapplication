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
    public class GetReplyByIdQuery : IRequest<Reply>
    {
        public Guid ReplyId { get; set; }
    }
    public class GetReplyByIdQueryHandler : IRequestHandler<GetReplyByIdQuery, Reply>
    {
        private readonly IReplyRepository _replyRepository;
        public GetReplyByIdQueryHandler(IReplyRepository replyRepository)
        {
            _replyRepository = replyRepository;
        }

        public async Task<Reply> Handle(GetReplyByIdQuery request, CancellationToken cancellationToken)
        {
            return await _replyRepository.GetReplyByIdAsync(request.ReplyId);
        }
    }
}
