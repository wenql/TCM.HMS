using System.Collections.Generic;
using Abp.Domain.Entities;

namespace TCM.HMS.Core.Physique
{
    public class Physique_Subject : Entity
    {
        /// <summary>
        /// 体质分类
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 分数集合
        /// </summary>
        public string Scores { get; set; }
    }
}
