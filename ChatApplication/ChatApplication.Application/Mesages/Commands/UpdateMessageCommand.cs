using ChatApplication.Domain.DTOs;
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
    public class UpdateMessageCommand : IRequest<Message>
    {
        public Guid MessageId { get; set; }
        public string Text { get; set; }
    }
    public class UpdateMessageCommandHandler : IRequestHandler<UpdateMessageCommand, Message>
    {
        private readonly IMessageRepository _messageRepository;
        public UpdateMessageCommandHandler(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public async Task<Message> Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
        {
            var message = await _messageRepository.GetMessageByIdAsync(request.MessageId);

            return await _messageRepository.UpdateMessageAsync(request.MessageId, new MessageUpdateDTO
            {
                Text = request.Text,
            });
        }
    }
}
