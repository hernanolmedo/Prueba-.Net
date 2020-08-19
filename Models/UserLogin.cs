using System.ComponentModel.DataAnnotations;

namespace Prueba_.Net.Models{
    public class UserLogin{

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

    }
}