using Abp.Application.Services;
using System.Threading.Tasks;
using TCM.HMS.Application.Physique.Dto;

namespace TCM.HMS.Application.Physique
{
    public interface IPhysiqueAppService : IApplicationService
    {
        /// <summary>
        /// 获取微信引导页配置
        /// </summary>
        /// <returns></returns>
        BootConfigDto GetBootConfig();

        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="model"></param>
        void SaveConfig(BootConfigDto model);
    }
}
