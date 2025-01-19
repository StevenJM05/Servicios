using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Servicios.Models;
namespace Servicios.DB
{
	public class ServiciosDBContext : IdentityDbContext<User>
	{
		public ServiciosDBContext(DbContextOptions<ServiciosDBContext> options) : base(options) {}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}


	}
}
