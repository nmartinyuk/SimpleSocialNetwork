using SimpleSocialNetwork.Data.DbContexts;
using System.Data.Entity.Migrations;

namespace SimpleSocialNetwork.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SimpleSocialNetworkDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SimpleSocialNetwork.App_Code.Database.SimpleSocialNetworkDbContext";
        }

        protected override void Seed(SimpleSocialNetworkDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
