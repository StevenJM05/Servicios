using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Servicios.DB;
using Servicios.Models;

namespace Servicios.Utils
{
	public static class IdentityServices
	{
		public static IServiceCollection AddIdentityServices(this IServiceCollection services)
		{
			services.AddIdentity<User, IdentityRole>(options =>
			{
				options.Password.RequireDigit = true;
				options.Password.RequiredLength = 8;
				options.Password.RequireUppercase = true;
			})
		   .AddEntityFrameworkStores<ServiciosDBContext>()
		   .AddDefaultTokenProviders();

			return services;
		}
	}
}
