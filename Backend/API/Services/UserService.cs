﻿using API.Models;
using API.Services.Interfaces;
using API.SqlRepository;

namespace API.Services
{
    public class UserService : IUserService
    {
        private readonly ISqlRepository<User> _userRepository;

        public UserService(ISqlRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task DeleteUserAsync(Guid id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateAsync(user);
        }
    }
}
