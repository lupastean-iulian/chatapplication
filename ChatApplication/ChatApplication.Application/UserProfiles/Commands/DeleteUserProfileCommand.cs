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
    public class DeleteUserProfileCommand : IRequest<UserProfile>
    {
        public Guid userId;
    }
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserProfileCommand, UserProfile>
    {
        private readonly IUserProfileRepository _userProfileRepository;

        public DeleteUserCommandHandler(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }
        public async Task<UserProfile> Handle(DeleteUserProfileCommand request, CancellationToken cancellationToken)
        {
            var user = await _userProfileRepository.GetUserProfileByIdAsync(request.userId);
            await _userProfileRepository.DeleteUserProfileAsync(user);

            return user;
        }

    }
}
