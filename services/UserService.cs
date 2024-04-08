using contracts.LogService;
using contracts.User;
using entities.DataTransferObjects.User;
using entities.Models;

namespace services;

public class UserService(IUserRepository userRepository, ILoggerManager logger) : IUserService
{
    private readonly ILoggerManager _logger = logger;
    public async Task<Guid> CreateUser(UserCreateRequest userCreateRequest)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Email = userCreateRequest.Email,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(userCreateRequest.Password),
            FirstName = userCreateRequest.FirstName,
            LastName = userCreateRequest.LastName,
            PhoneNumber = userCreateRequest.PhoneNumber,
            RoleId = userCreateRequest.RoleId
        };

        await userRepository.CreateUser(user);
        _logger.LogInfo($"User with email {user.Email} has been created");
        return user.Id;
    }

    public Task<bool> IsUserExist(string email)
    {
        return userRepository.IsUserExist(email);
    }
}