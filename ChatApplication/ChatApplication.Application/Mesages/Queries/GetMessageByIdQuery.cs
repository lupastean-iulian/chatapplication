using ChatApplication.Domain.Entities;
using ChatApplication.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Application.Mesages.Queries
{
    public class GetMessageByIdQuery : IRequest<Message>
    {
        public Guid MessageId { get; set; }
    }
    public class GetMessageByIdQueryHandler : IRequestHandler<GetMessageByIdQuery, Message>
    {
        private readonly IMessageRepository _messageRepository;
        public GetMessageByIdQueryHandler(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public async Task<Message> Handle(GetMessageByIdQuery request, CancellationToken cancellationToken)
        {
            return await _messageRepository.GetMessageByIdAsync(request.MessageId);
        }
    }
}
