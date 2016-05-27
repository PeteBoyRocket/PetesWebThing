using System.Data.Entity.Migrations;

namespace DBRepo.Migrations
{
	internal class Configuration : DbMigrationsConfiguration<CardsContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}
	}
}
