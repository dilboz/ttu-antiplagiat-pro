using entities.DataTransferObjects.User;

namespace contracts.User;

public interface IUserService
{
    Task<Guid> CreateUser(UserCreateRequest userCreateRequest);
    Task<bool> IsUserExist(string email);
}