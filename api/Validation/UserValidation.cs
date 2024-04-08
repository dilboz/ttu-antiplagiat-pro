using System.Net;
using api.ViewResponse;
using contracts.User;
using entities.DataTransferObjects.User;
using entities.Enums;
using entities.Helpers;

namespace api.Validation
{
    public class UserValidation(IUserService userService) : IUserValidation
    {
        public async Task<Guid> CreateUser(UserCreateRequest userCreateRequest)
        {
            //check if user exist
            var isUserExist = await userService.IsUserExist(userCreateRequest.Email);
            
            if (isUserExist)
                throw new ResultResponseException(HttpStatusCode.BadRequest, "User already exist");
            
            if (string.IsNullOrEmpty(userCreateRequest.Email))
                throw new ResultResponseException(HttpStatusCode.BadRequest, "Email is required");
            
            if (string.IsNullOrEmpty(userCreateRequest.Password))
                throw new ResultResponseException(HttpStatusCode.BadRequest, "Password is required");
            
            if (string.IsNullOrEmpty(userCreateRequest.FirstName))
                throw new ResultResponseException(HttpStatusCode.BadRequest, "First name is required");
            
            if (string.IsNullOrEmpty(userCreateRequest.LastName))
                throw new ResultResponseException(HttpStatusCode.BadRequest, "Last name is required");
            
            if (string.IsNullOrEmpty(userCreateRequest.PhoneNumber))
                throw new ResultResponseException(HttpStatusCode.BadRequest, "Phone number is required");
            
            if (!Enum.IsDefined(typeof(Roles), userCreateRequest.RoleId))
                throw new ResultResponseException(HttpStatusCode.BadRequest, "Invalid role");
            
            return await userService.CreateUser(userCreateRequest);
        }
    }
}