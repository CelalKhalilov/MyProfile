using System.Data.Entity;

namespace MyWebSite.Models.Siniflar
{
	public class Context : DbContext
	{
		public DbSet<Admin> Admins { get; set; }
		public DbSet<AnaSayfa> AnaSayfas { get; set; }
		public DbSet<İkonlar> İkonlars { get; set; }
	}
}