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
    public class CreateReplyCommand : IRequest<Reply>
    {
        public Guid MessageId { get; set; }
        public Guid UserId { get; set; }
        public string Text { get; set; }
    }
    public class CreatereplyCommandHandler : IRequestHandler<CreateReplyCommand, Reply>
    {
        private readonly IReplyRepository _replyRepository;
        public CreatereplyCommandHandler(IReplyRepository replyRepository)
        {
            _replyRepository = replyRepository;
        }

        public async Task<Reply> Handle(CreateReplyCommand request, CancellationToken cancellationToken)
        {
            var date = DateTime.UtcNow;
            return await _replyRepository.CreateReplyAsync(new Reply
            {
                Id = Guid.NewGuid(),
                MessageId = request.MessageId,
                UserId = request.UserId,
                Text = request.Text,
                CreationDate = date,
                LastEditDate = date
            });
        }
    }
}
