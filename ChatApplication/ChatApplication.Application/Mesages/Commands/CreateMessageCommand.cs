using ChatApplication.Domain.Entities;
using ChatApplication.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Application.Mesages.Commands
{
    public class CreateMessageCommand : IRequest<Message>
    {
        public string Text { get; set; }
        public Guid UserId { get; set; }
    }

    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand, Message>
    {
        private readonly IMessageRepository _messageRepository;
        public CreateMessageCommandHandler(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public async Task<Message> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            var date = DateTime.UtcNow;
            return await _messageRepository.CreateMessageAsync(new Message
            {
                Id = Guid.NewGuid(),
                Text = request.Text,
                UserId = request.UserId,
                CreationDate = date,
                LastEditDate = date
            });
        }
    }
}
