using ChatApplication.Dal.NewFolder;
using ChatApplication.Domain.DTOs;
using ChatApplication.Domain.Entities;
using ChatApplication.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> CheckUserExistsAsync(Guid userId)
        {
            return await _ctx.UserProfiles.AnyAsync(x => x.Id.Equals(userId));
        }

        public async Task<UserProfile> CreateUserProfileAsync(UserProfile userProfile)
        {
            _ctx.UserProfiles.Add(userProfile);
            await _ctx.SaveChangesAsync();
            return userProfile;
        }

        public async Task DeleteUserProfileAsync(UserProfile userProfile)
        {
            _ctx.Remove(userProfile);
            await _ctx.SaveChangesAsync();
        }

        public async Task<List<UserProfile>> GetAllUserProfilesAsync()
        {
            return await _ctx.UserProfiles.AsNoTracking().ToListAsync();
        }

        public async Task<UserProfile?> GetUserProfileByIdAsync(Guid userId)
        {
            return await _ctx.UserProfiles.FirstOrDefaultAsync(x => x.Id.Equals(userId));
        }

        public async Task<UserProfile> UpdateUserProfileAsync(Guid userId, UserProfileUpdateDTO userProfile)
        {
            var profileToUpdate = await GetUserProfileByIdAsync(userId);

            profileToUpdate.DisplayName = userProfile.DisplayName;
            profileToUpdate.EmailAddress = userProfile.EmailAddress;

            await _ctx.SaveChangesAsync();
            return profileToUpdate;
        }
    }
}
