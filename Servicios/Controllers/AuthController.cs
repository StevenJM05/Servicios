using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Servicios.Models;
using Servicios.Models.DTOs;
using Servicios.Services;
namespace Servicios.Controllers
{
	[Route("api/[Controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly UserManager<User> _userManager;
		private readonly JwtService _jwtService;

		public AuthController(UserManager<User> userManager, JwtService jwtService)
		{
			_userManager = userManager;
			_jwtService = jwtService;
		}

		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] RegisterDto dto)
		{
			//Creamos el objeto usuario
			var user = new User
			{
				UserName = dto.Email,
				Email = dto.Email,
				Name = dto.Name,
				ProfilePicture = dto.ProfilePicture,
				Location = dto.Location,
			};

			//Lo creamos en la base de datos
			var result = await _userManager.CreateAsync(user, dto.Password);

			if (!result.Succeeded)
			{
				return BadRequest(result.Errors);
			}

			return Ok("User registered successfully");
		}

	}
}
