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
    public class DeleteMessageCommand : IRequest<Message>
    {
        public Guid MessageId { get; set; }
    }
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, Message>
    {
        private readonly IMessageRepository _messageRepository;
        public DeleteMessageCommandHandler(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public async Task<Message> Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
        {
            var message = await _messageRepository.GetMessageByIdAsync(request.MessageId);

            await _messageRepository.DeleteMessageAsync(message);

            return message;
        }
    }
}
