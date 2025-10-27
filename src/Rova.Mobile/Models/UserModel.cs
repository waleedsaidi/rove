using System;

namespace Rova.Mobile.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // e.g., Merchant or Worker
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}