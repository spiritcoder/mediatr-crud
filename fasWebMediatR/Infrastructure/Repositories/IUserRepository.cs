using fasWebMediatR.Domain.Entities;

namespace fasWebMediatR.Infrastructure.Repositories;

public interface IUserRepository
{
    Task<User> GetUserByIdAsync(int id);
    Task<User> AddUserAsync(User user);
    Task<User[]> GetAllUsersAsync();
    Task<User> UpdateUserAsync(User user);
    Task<bool> DeleteUserAsync(int id);
}
