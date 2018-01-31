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

            var scores = "1,2,3,4,5";
            var scoresDesc = "5,4,3,2,1";

            #region ƽ����

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "������������",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "������ƣ����",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "��˵������������������",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���о������Ʋ����������ͳ���",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����һ�����ܲ��˺����������������յ�����",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���ܺܿ���Ӧ��Ȼ��������ỷ���ı仯��",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "������ʧ�ߣ�û�кܺõ�ʧ����������",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���������£���������",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });

            #endregion

            #region ������

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���������̣������̴٣��Ӳ���������",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "������ƣ����",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "�������Ļ���",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "������ͷ�λ�վ����ѣ����",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����һ�������׻���ð��",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "��ϲ������������˵����",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����˵����������������",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���Ļ���Դ�����׳��麹��",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });

            #endregion

            #region ������

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���ֽŷ�����",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����θ�䲿����������ϥ��������",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���е����䡢�·��ȱ��˴��Ķ���",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���Ժ��������е���������³Ժ���������",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����һ�����ܲ��˺����������������յ�����",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���ȱ������׻���ð��",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���������߳Ժ������������������ӣ���к����",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });

            #endregion

            #region ������

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���е����Ľ��ķ�����",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���о����塢���Ϸ�����",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����Ƥ�����߿ڴ�����",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���Ŀڴ���ɫ��һ���˺���",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "�����ױ��ػ��ߴ�������",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���沿��ȧ�������ƫ����",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "�����۾��е���ɬ��",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���е��ڸ���������ˮ��",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });

            #endregion

            #region ̵ʪ��

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���е����ƻ��߸���������",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���е�������ز����ɻ�ˬ����",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���ĸ�������������",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���ж�ͷ����֬���ڹ����������",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���������ȱ����ף���������΢¡��������",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����������ĸо�����",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "��ƽʱ̵�࣬�ر����ʺ��ܸе���̵�ĸо���",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����̦�����������̦���ĸо���",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });

            #endregion

            #region ʪ����

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���沿���߱��Ӳ�������л����͹ⷢ����",
                CategoryId = (int)SubjectCategory.DampHeat,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���������������",
                CategoryId = (int)SubjectCategory.DampHeat,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���е��ڿ���߿�������ζ��",
                CategoryId = (int)SubjectCategory.DampHeat,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "��С��ʱ����з��ȸУ���ɫŨ�����",
                CategoryId = (int)SubjectCategory.DampHeat,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "������ɫ�ƣ��״���ɫ���ƣ�����Ů�Իش�",
                CategoryId = (int)SubjectCategory.DampHeat,
                OnlySex = 0,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "�������Ҳ�λ��ʪ�������Իش�",
                CategoryId = (int)SubjectCategory.DampHeat,
                OnlySex = 1,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "�������Ͳ�ˬ���нⲻ���ĸо���",
                CategoryId = (int)SubjectCategory.DampHeat,
                Scores = scores
            });

            #endregion

            #region Ѫ����

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����Ƥ���ڲ�֪�����л�����������ߣ�Ƥ�³�Ѫ����",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����ȧ����ϸ΢��˿��",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����������������ʹ��",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "������ɫ�ް������׳��ְֺ���",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "�������к���Ȧ��",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���ڴ���ɫƫ����",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "������������",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });


            #endregion

            #region ������

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���о������Ʋ��֣������ͳ���",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "�����׾�����š����ǲ�����",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "������ƸС����������",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "�����׸е����»����ܵ�������",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "��в�߲����鷿��ʹ��",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����Ե�޹�̾����",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���ʲ�������У�����֮��������֮������",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });

            #endregion

            #region ������

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "��û�и�ðʱҲ���������",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "��û�и�ðҲ���������������",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "���м��ڱ仯���¶ȱ仯����ζ���ȴ�������",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "�����׹�������ҩ�ʳ���ζ�����ۣ���",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����Ƥ������������������š�����飬������",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����Ƥ�������������񰣨�Ϻ�ɫ춵㡢���ߣ���",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "����Ƥ��һץ�ͺ죬������ץ����",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });

            #endregion
        }
    }
}
