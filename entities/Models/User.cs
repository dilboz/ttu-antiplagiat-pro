using System.ComponentModel.DataAnnotations;
using entities.Enums;

namespace entities.Models;

public class User
{
    [Key]
    public Guid Guid { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public Roles RoleId { get; set; }
    public string? ResetToken { get; set; }
    public DateTimeOffset ResetTokenByLoginExpires { get; set; }
    public virtual Role? Role { get; set; }
    public virtual IEnumerable<Otp>? Otps { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
}