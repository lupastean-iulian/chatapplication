using ChatApplication.Domain.Entities;
using ChatApplication.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Application.UserProfiles.Queries
{
    public class GetUserProfileByIdQuery : IRequest<UserProfile>
    {
        public Guid UserId { get; set; }
    }
    public class GetUserProfileByIdQueryHandler : IRequestHandler<GetUserProfileByIdQuery, UserProfile>
    {
        private readonly IUserProfileRepository _userProfileRepository;

        public GetUserProfileByIdQueryHandler(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }
        public async Task<UserProfile> Handle(GetUserProfileByIdQuery request, CancellationToken cancellationToken)
        {
            return await _userProfileRepository.GetUserProfileByIdAsync(request.UserId);
        }
    }
}
