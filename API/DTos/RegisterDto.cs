using System.ComponentModel.DataAnnotations;

namespace API.DTos
{
    public class RegisterDto
    {
        [Required] //dataAnnotation
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}