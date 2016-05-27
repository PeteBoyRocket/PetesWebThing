using System.Data.Entity;
using DBRepo.Migrations;

namespace DBRepo
{
	internal class CardsContext : DbContext
	{
		public CardsContext()
			: base("name=PetesDatabase")
		{ }

		public DbSet<Black> Blacks { get; set; }

		public DbSet<White> Whites { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<CardsContext, Configuration>());
		}
	}
}
