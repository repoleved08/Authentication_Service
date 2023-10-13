using System.ComponentModel.DataAnnotations;

namespace HMS_Authentication.Models.Dto
{
    public class RegisterRequestDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }=string.Empty;

        [Required]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; }= string.Empty;

        [Required]
        public string PhoneNumber { get; set;}=string.Empty;
    }
}
