using ChatApplication.Domain.DTOs;
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
    public class UpdateUserProfileCommand : IRequest<UserProfile>
    {
        public Guid UserId { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
    }

    public class UpdateUserProfileCommandHandler : IRequestHandler<UpdateUserProfileCommand, UserProfile>
    {
        private readonly IUserProfileRepository _userProfileRepository;

        public UpdateUserProfileCommandHandler(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }
        public async Task<UserProfile> Handle(UpdateUserProfileCommand request, CancellationToken cancellationToken)
        {
            return await _userProfileRepository.UpdateUserProfileAsync(request.UserId, new UserProfileUpdateDTO
            {
                DisplayName = request.DisplayName,
                EmailAddress = request.EmailAddress
            });
        }
    }
}
