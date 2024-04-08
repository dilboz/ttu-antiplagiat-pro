using entities.DataTransferObjects.User;

namespace contracts.User;

public interface IUserValidation
{
    public Task<Guid> CreateUser(UserCreateRequest userCreateRequest);
}