using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ChatApplication.API.Controllers
{
    public class UserProfileController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public UserProfileController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
    }
}
