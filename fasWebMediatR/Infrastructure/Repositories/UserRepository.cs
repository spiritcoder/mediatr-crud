using fasWebMediatR.Domain;
using fasWebMediatR.Domain.Entities;

namespace fasWebMediatR.Infrastructure.Repositories;

public class UserRepository(DataDbContext context) : IUserRepository
{
    public async Task<User> GetUserByIdAsync(int id)
    {
        return await context.Users.FindAsync(id);
    }

    public async Task<User> AddUserAsync(User user)
    {
        var savedUser = await context.Users.AddAsync(user);
        await context.SaveChangesAsync();

        return savedUser.Entity;
    }

    public async Task<User[]> GetAllUsersAsync()
    {
        return context.Users.ToArray();
    }

    public async Task<User> UpdateUserAsync(User user)
    {
        var updatedUser = context.Users.Update(user);
        await context.SaveChangesAsync();
        
        return updatedUser.Entity;
    }

    public async Task<bool> DeleteUserAsync(int id)
    {
        var user = await context.Users.FindAsync(id);
        context.Users.Remove(user);
        var contentSaved = await context.SaveChangesAsync();
        
        if (contentSaved > 0)
        {
            return true;
        }
        return false;
    }
}
