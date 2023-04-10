using System.ComponentModel.DataAnnotations;

namespace PresProje.Models
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [Required]
        public string? Status { get; set; }
        public bool KeepLoggedIn { get; set; }
    }
}
