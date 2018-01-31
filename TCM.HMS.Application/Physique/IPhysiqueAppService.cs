using System.Collections.Generic;
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

        /// <summary>
        /// 获取判定表
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        List<SubjectListDto> GetSubjects(int categoryId);

        /// <summary>
        /// 获取判定表
        /// </summary>
        /// <returns></returns>
        List<SubjectListDto> GetSubjects();

        /// <summary>
        /// 获取判定表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SubjectDto GetSubject(int id);

        /// <summary>
        /// 保存判定表
        /// </summary>
        /// <param name="model"></param>
        void SaveSubject(SubjectDto model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        void DeleteSubject(int id);

        /// <summary>
        /// 获取医生分析
        /// </summary>
        /// <returns></returns>
        DocumentDto GetDocument(int categoryId);

        void SaveDocument(DocumentDto model);

        List<DocumentDto> GetDocuments(List<int> categoryIds);
    }
}
