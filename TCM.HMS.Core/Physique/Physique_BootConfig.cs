using Abp.Domain.Entities;

namespace TCM.HMS.Core.Physique
{
    /// <summary>
    /// 微信体质辨识引导页
    /// </summary>
    public class Physique_BootConfig : Entity
    {
        public Physique_BootConfig() { }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}
