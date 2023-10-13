using Microsoft.AspNetCore.Identity;

namespace HMS_Authentication.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string Name { get; set; }=string.Empty;
		//public string Role { get; set; } = "Patient";
    }
}
