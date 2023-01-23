using ChatApplication.Dal.NewFolder;
using ChatApplication.Domain.Entities;
using ChatApplication.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Dal.Repositories
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly ChatApplicationContext _ctx;
        public UserProfileRepository(ChatApplicationContext ctx)
        {
            _ctx = ctx;
        }

        public Task<bool> CheckUserExistsAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> CreateUserProfileAsync(UserProfile userProfile)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserProfileAsync(UserProfile userProfile)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserProfile>> GetAllUserProfilesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> GetUserProfileByIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> UpdateUserProfileAsync(UserProfile userProfile)
        {
            throw new NotImplementedException();
        }
    }
}
