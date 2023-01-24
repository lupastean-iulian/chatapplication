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
    public class GetAllMesagesForUserQuery : IRequest<List<Message>>
    {
        public Guid UserId { get; set; }
    }
    public class GetAllMessagesForUserQueryHandler : IRequestHandler<GetAllMesagesForUserQuery, List<Message>>
    {
        private readonly IMessageRepository _messageRepository;
        public GetAllMessagesForUserQueryHandler(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public async Task<List<Message>> Handle(GetAllMesagesForUserQuery request, CancellationToken cancellationToken)
        {
            return await _messageRepository.GetAllMessagesForUserAsync(request.UserId);
        }
    }
}
