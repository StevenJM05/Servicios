using Microsoft.EntityFrameworkCore;
namespace Servicios.DB
{
	public class ServiciosDBContext : DbContext
	{
		public ServiciosDBContext(DbContextOptions<ServiciosDBContext> options) : base(options) { }


	}
}
