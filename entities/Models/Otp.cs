using System.ComponentModel.DataAnnotations;

namespace entities.Models
{
    public class Otp
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Key { get; set; }
        public string Message { get; set; }
        public bool IsUsed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiredAt { get; set; }
    }
}