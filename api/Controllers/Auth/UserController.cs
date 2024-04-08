using System.Net;
using api.ViewResponse;
using contracts.User;
using entities.DataTransferObjects.User;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserValidation userValidation) : ControllerBase
    {
        [HttpPost("create")]
        public async Task<ApiResponse> CreateUser([FromBody] UserCreateRequest userCreateRequest)
        {
            try
            {
                var userId = await userValidation.CreateUser(userCreateRequest);
                
                if (userId == Guid.Empty)
                    throw new ResultResponseException(HttpStatusCode.InternalServerError, "User creation failed");
                
                return ApiResponse.Success(userId.ToString(), "User created successfully");
            }
            catch (ResultResponseException e)
            {
                return ApiResponse.NotSuccess(e.GetErrorCode(), e.GetErrorMessage());
            }
        }
    }
}