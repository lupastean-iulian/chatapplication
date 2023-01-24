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
    public class GetAllUserProfliesQuery : IRequest<List<UserProfile>>
    {

    }

    public class GetAllUserProfilesQueryHandler : IRequestHandler<GetAllUserProfliesQuery, List<UserProfile>>
    {
        private readonly IUserProfileRepository _userProfileRepository;
        public GetAllUserProfilesQueryHandler(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public async Task<List<UserProfile>> Handle(GetAllUserProfliesQuery request, CancellationToken cancellationToken)
        {
            return await _userProfileRepository.GetAllUserProfilesAsync();
        }
    }
}
