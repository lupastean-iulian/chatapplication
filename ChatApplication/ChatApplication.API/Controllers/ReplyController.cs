using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ChatApplication.API.Controllers
{
    public class ReplyController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public ReplyController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
    }
}
