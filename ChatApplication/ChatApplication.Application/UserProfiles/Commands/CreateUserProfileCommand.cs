using ChatApplication.Domain.Entities;
using ChatApplication.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Application.UserProfiles.Commands
{
    public class CreateUserProfileCommand : IRequest<UserProfile>
    {
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
    }

    public class CreateUserProfileCommandHandler : IRequestHandler<CreateUserProfileCommand, UserProfile>
    {
        private readonly IUserProfileRepository _userProfileRepository;
        public CreateUserProfileCommandHandler(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public async Task<UserProfile> Handle(CreateUserProfileCommand request, CancellationToken cancellationToken)
        {
            return await _userProfileRepository.CreateUserProfileAsync(new UserProfile
            {
                Id = Guid.NewGuid(),
                DisplayName = request.DisplayName,
                EmailAddress = request.EmailAddress,
            });
        }
    }
}
