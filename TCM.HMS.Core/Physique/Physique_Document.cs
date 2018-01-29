using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace TCM.HMS.Core.Physique
{
    public class Physique_Document : Entity
    {
        /// <summary>
        /// 体质分类
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 总体特征
        /// </summary>
        public string Zttz { get; set; }

        /// <summary>
        /// 形体特征
        /// </summary>
        public string Xttz { get; set; }

        /// <summary>
        /// 常见表现
        /// </summary>
        public string Cjbx { get; set; }

        /// <summary>
        /// 心理特征
        /// </summary>
        public string Xltz { get; set; }

        /// <summary>
        /// 发病倾向
        /// </summary>
        public string Fbqx { get; set; }

        /// <summary>
        /// 对外界环境适应能力
        /// </summary>
        public string Hjsy { get; set; }

        /// <summary>
        /// 运动调养
        /// </summary>
        public string Ydty { get; set; }

        /// <summary>
        /// 药物调养
        /// </summary>
        public string Ywty { get; set; }

        /// <summary>
        /// 调养方法
        /// </summary>
        public string Tyff { get; set; }

        /// <summary>
        /// 健康食谱
        /// </summary>
        public string Jksp { get; set; }
    }
}
