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
                    Title = "��������",
                    Content = "�𾴵��û����Ѽ�����ҽ���������ںţ�Ϊ�˸���Ϊ���ṩ��������д׼ȷ�ĸ�����Ϣ�����ǽ������ĸ�����Ϣ���б��ܣ�������ҽԺ�ڲ��ṩ����ʹ�á�"
                });
        }
    }
}
