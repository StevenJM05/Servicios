using Microsoft.AspNetCore.Identity;

namespace Servicios.Models
{
	public class User : IdentityUser
	{
	
		public string Name { get; set; }
		public String ProfilePicture { get; set; }
		public String Location { get; set; }
		
	}
}
