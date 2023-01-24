using ChatApplication.Domain.DTOs;
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
    public class UpdateReplyCommand : IRequest<Reply>
    {
        public Guid ReplyId { get; set; }
        public string Text { get; set; }

    }
    public class UpdateReplyCommandHandler : IRequestHandler<UpdateReplyCommand, Reply>
    {
        private readonly IReplyRepository _replyRepository;
        public UpdateReplyCommandHandler(IReplyRepository replyRepository)
        {
            _replyRepository = replyRepository;
        }

        public async Task<Reply> Handle(UpdateReplyCommand request, CancellationToken cancellationToken)
        {
            return await _replyRepository.UpdateReplyAsync(request.ReplyId, new ReplyUpdateDTO
            {
                Text = request.Text,
            });
        }
    }
}
