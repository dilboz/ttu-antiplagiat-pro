using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using entities.Enums;

namespace entities.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Roles RoleId { get; set; }
        public string? ResetToken { get; set; }
        public DateTime? ExparedResetToken { get; set; }
        public virtual Role? Role { get; set; } public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}