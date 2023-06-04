using Microsoft.Build.Framework;

namespace HotelProject.WebUI.Dtos.Login
{
    public class LoginUserDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
