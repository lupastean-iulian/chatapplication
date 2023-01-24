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
    public class GetAllRepliesForMessageQuery : IRequest<List<Reply>>
    {
        public Guid MessageId { get; set; }
    }
    public class GetAllRepliesForMessageQueryHandler : IRequestHandler<GetAllRepliesForMessageQuery, List<Reply>>
    {
        private readonly IReplyRepository _replyRepository;
        public GetAllRepliesForMessageQueryHandler(IReplyRepository replyRepository)
        {
            _replyRepository = replyRepository;
        }

        public async Task<List<Reply>> Handle(GetAllRepliesForMessageQuery request, CancellationToken cancellationToken)
        {
            return await _replyRepository.GetAllRepliesForMessageAsync(request.MessageId);
        }
    }
}
