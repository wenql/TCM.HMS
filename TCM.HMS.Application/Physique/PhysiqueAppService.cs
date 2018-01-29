using Abp.Domain.Repositories;
using AutoMapper;
using System.Linq;
using TCM.HMS.Core.Physique;
using TCM.HMS.Application.Physique.Dto;
using System.Threading.Tasks;

namespace TCM.HMS.Application.Physique
{
    public class PhysiqueAppService : IPhysiqueAppService
    {
        private readonly IRepository<Physique_BootConfig> _bootConfigRepository;
        public PhysiqueAppService(IRepository<Physique_BootConfig> bootConfigRepository)
        {
            this._bootConfigRepository = bootConfigRepository;
        }
        public BootConfigDto GetBootConfig()
        {
            return Mapper.Map<BootConfigDto>(this._bootConfigRepository.GetAllList().OrderByDescending(x => x.Id).FirstOrDefault());
        }

        public void SaveConfig(BootConfigDto model)
        {
            this._bootConfigRepository.InsertOrUpdate(Mapper.Map<Physique_BootConfig>(model));
        }
    }
}
