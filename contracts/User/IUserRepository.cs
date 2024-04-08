using entities.DataTransferObjects.User;

namespace contracts.User;

public interface IUserRepository
{
    Task<Guid> CreateUser(entities.Models.User user);
    Task<bool> IsUserExist(string email);
}