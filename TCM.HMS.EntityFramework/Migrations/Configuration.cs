using System.Data.Entity.Migrations;

namespace TCM.HMS.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<HMS.EntityFramework.HMSDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HMS";
        }

        protected override void Seed(HMS.EntityFramework.HMSDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
