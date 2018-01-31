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

            var scores = "1,2,3,4,5";
            var scoresDesc = "5,4,3,2,1";

            #region 平和质

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您精力充沛吗",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易疲乏吗",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您说话的声音柔弱无力吗",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您感觉到闷闷不乐吗情绪低沉吗",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您比一般人受不了寒凉（冬天冷和夏天空调）吗",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您能很快适应自然环境和社会环境的变化吗",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易失眠（没有很好的失眠质量）吗",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易忘事（健忘）吗",
                CategoryId = (int)SubjectCategory.YinYangHarmony,
                Scores = scoresDesc
            });

            #endregion

            #region 气虚型

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易气短（呼吸短促，接不上气）吗",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易疲乏吗",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易心慌吗",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易头晕或站起来眩晕吗",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您比一般人容易患感冒吗",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您喜欢安静，懒得说话吗",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的说话声音低若无力吗",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的活动量稍大就容易出虚汗吗",
                CategoryId = (int)SubjectCategory.QiAsthenia,
                Scores = scores
            });

            #endregion

            #region 阳虚型

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您手脚发凉吗",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的胃脘部、背部、腰膝部怕冷吗",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您感到怕冷、衣服比别人穿的多吗",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您吃喝凉东西感到不舒服或怕吃喝凉东西吗",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您比一般人受不了寒凉（冬天冷和夏天空调）吗",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您比别人容易患感冒吗",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您受凉或者吃喝凉东西后，容易拉肚子（腹泻）吗",
                CategoryId = (int)SubjectCategory.YangAsthenia,
                Scores = scores
            });

            #endregion

            #region 阴虚型

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您感到手心脚心发热吗",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您感觉身体、脸上发热吗",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的皮肤或者口唇干吗",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的口唇颜色比一般人红吗",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易便秘或者大便干燥吗",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您面部两颧潮红或者偏红吗",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的眼睛感到干涩吗",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您感到口干咽燥，总想喝水吗",
                CategoryId = (int)SubjectCategory.YinaAthenia,
                Scores = scores
            });

            #endregion

            #region 痰湿型

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您感到胸闷或者腹部胀满吗",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您感到身体沉重不轻松或不爽快吗",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的腹部肥满松软吗",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您有额头部油脂分泌过多的显现吗",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您上眼脸比别人肿（或者有轻微隆起现象）吗",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您嘴里有黏黏的感觉嘛吗",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您平时痰多，特别是咽喉部总感到有痰的感觉吗",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您舌苔厚腻或者有舌苔厚厚的感觉吗",
                CategoryId = (int)SubjectCategory.PhlegmDampness,
                Scores = scores
            });

            #endregion

            #region 湿热型

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您面部或者鼻子步有油腻感或者油光发亮吗",
                CategoryId = (int)SubjectCategory.DampHeat,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易生痤疮或疮疖吗",
                CategoryId = (int)SubjectCategory.DampHeat,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您感到口苦或者口里有异味吗",
                CategoryId = (int)SubjectCategory.DampHeat,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您小便时尿道有发热感，尿色浓（深）吗",
                CategoryId = (int)SubjectCategory.DampHeat,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您带下色黄（白带颜色发黄）吗（限女性回答）",
                CategoryId = (int)SubjectCategory.DampHeat,
                OnlySex = 0,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的阴囊部位潮湿吗（限男性回答）",
                CategoryId = (int)SubjectCategory.DampHeat,
                OnlySex = 1,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您大便黏滞不爽、有解不尽的感觉吗",
                CategoryId = (int)SubjectCategory.DampHeat,
                Scores = scores
            });

            #endregion

            #region 血瘀型

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的皮肤在不知不觉中会出现青紫瘀斑（皮下出血）吗",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您两颧部有细微红丝吗",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您身体上有那里疼痛吗",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的面色晦暗或容易出现褐斑吗",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易有黑眼圈吗",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您口唇颜色偏黯吗",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易忘事吗",
                CategoryId = (int)SubjectCategory.BloodStasis,
                Scores = scores
            });


            #endregion

            #region 气郁型

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您感觉到闷闷不乐，情绪低沉吗",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易精神紧张、焦虑不安吗",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您多愁善感、感情脆弱吗",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易感到害怕或者受到惊吓吗",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您胁肋部或乳房胀痛吗",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您无缘无故叹气吗",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您咽部有异物感，且吐之不出，咽之不下吗",
                CategoryId = (int)SubjectCategory.QiStagnation,
                Scores = scores
            });

            #endregion

            #region 特禀型

            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您没有感冒时也会打喷嚏吗",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您没有感冒也会鼻塞、流鼻涕吗",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您有季节变化，温度变化或异味而咳喘现象吗",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您容易过敏（对药物、食物、气味、花粉）吗",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的皮肤容易引起需麻疹（风团、风疹块，风疙瘩）吗",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的皮肤因过敏出现紫癜（紫红色於点、瘀斑）吗",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });
            context.Subjects.AddOrUpdate(p => p.Title, new Physique_Subject
            {
                Title = "您的皮肤一抓就红，并出现抓痕吗",
                CategoryId = (int)SubjectCategory.Allergic,
                Scores = scores
            });

            #endregion
        }
    }
}
