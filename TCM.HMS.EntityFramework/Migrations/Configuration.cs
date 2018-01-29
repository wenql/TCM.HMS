using System.Data.Entity.Migrations;
using TCM.HMS.Core.Physique;

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
            context.PhysiqueBoots.AddOrUpdate(p => p.Title,
                new Physique_BootConfig
                {
                    Title = "免责申明",
                    Content = "尊敬的用户您已加入中医健康管理公众号，为了更好为您提供服务，请填写准确的个人信息，我们将对您的个人信息进行保密，仅进行医院内部提供服务使用。"
                });
        }
    }
}
