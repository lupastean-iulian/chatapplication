using ChatApplication.Domain.DTOs;
using ChatApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Domain.Interfaces
{
    public interface IUserProfileRepository
    {
        Task<UserProfile> CreateUserProfileAsync(UserProfile userProfile);
        Task<UserProfile> UpdateUserProfileAsync(Guid userId, UserProfileUpdateDTO userProfile);
        Task DeleteUserProfileAsync(UserProfile userProfile);
        Task<UserProfile?> GetUserProfileByIdAsync(Guid userId);
        Task<List<UserProfile>> GetAllUserProfilesAsync();
        Task<bool> CheckUserExistsAsync(Guid userId);

    }
}
