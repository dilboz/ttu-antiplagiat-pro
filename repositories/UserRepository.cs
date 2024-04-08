using contracts.User;
using entities.DataContexts;
using entities.Models;
using Microsoft.EntityFrameworkCore;

namespace repositories;

public class UserRepository(DataContext dataContext) : IUserRepository
{
    public async Task<Guid> CreateUser(User user)
    {
        await dataContext.Users.AddAsync(user);
        await dataContext.SaveChangesAsync();
        return user.Id;
    }

    public Task<bool> IsUserExist(string email)
    {
        return dataContext.Users.AnyAsync(x => x.Email == email);
    }
}