using ChatApplication.Domain.Entities;
using ChatApplication.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Application.Replies.Commands
{
    public class DeleteReplyCommand : IRequest<Reply>
    {
        public Guid ReplyId { get; set; }
    }

    public class DeleteReplyCommandHandler : IRequestHandler<DeleteReplyCommand, Reply>
    {
        private readonly IReplyRepository _replyRepository;
        public DeleteReplyCommandHandler(IReplyRepository replyRepository)
        {
            _replyRepository = replyRepository;
        }

        public async Task<Reply> Handle(DeleteReplyCommand request, CancellationToken cancellationToken)
        {
            var reply = await _replyRepository.GetReplyByIdAsync(request.ReplyId);
            await _replyRepository.DeleteReplyAsync(reply);

            return reply;
        }
    }
}
