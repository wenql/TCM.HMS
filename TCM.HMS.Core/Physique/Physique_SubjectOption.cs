using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCM.HMS.Core.Physique
{
    public class Physique_SubjectOption : Entity
    {
        /// <summary>
        /// 对应标题Id
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// 题目
        /// </summary>
        [ForeignKey("SubjectId")]
        public Physique_Subject Subject { get; set; }
    }
}
