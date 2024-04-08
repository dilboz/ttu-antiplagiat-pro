using System.ComponentModel.DataAnnotations;
using entities.Enums;

namespace entities.DataTransferObjects.User;

public class UserCreateRequest
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public Roles RoleId { get; set; }   
}