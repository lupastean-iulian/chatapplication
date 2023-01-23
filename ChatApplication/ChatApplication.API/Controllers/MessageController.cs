using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ChatApplication.API.Controllers
{
    public class MessageController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public MessageController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
    }
}
