using System.Data.Entity;

namespace DBRepo
{
	internal class CardsContext : DbContext
	{
		public DbSet<Black> Blacks { get; set; }
	}
}
