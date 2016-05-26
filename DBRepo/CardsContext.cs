using System.Data.Entity;

namespace DBRepo
{
	internal class CardsContext : DbContext
	{
		public CardsContext()
			: base("name=PetesDatabase")
		{ }

		public DbSet<Black> Blacks { get; set; }

		public DbSet<White> Whites { get; set; }
	}
}
