using System.Collections.Generic;
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
        private readonly IRepository<Physique_Subject> _physiqueSubjectRepository;
        private readonly IRepository<Physique_Document> _physiqueDocumentRepository;

        public PhysiqueAppService(IRepository<Physique_BootConfig> bootConfigRepository,
            IRepository<Physique_Subject> physiqueSubjectRepository,
            IRepository<Physique_Document> physiqueDocumentRepository)
        {
            this._bootConfigRepository = bootConfigRepository;
            this._physiqueSubjectRepository = physiqueSubjectRepository;
            this._physiqueDocumentRepository = physiqueDocumentRepository;
        }

        public BootConfigDto GetBootConfig()
        {
            return Mapper.Map<BootConfigDto>(this._bootConfigRepository.GetAllList().OrderByDescending(x => x.Id).FirstOrDefault());
        }

        public void SaveConfig(BootConfigDto model)
        {
            this._bootConfigRepository.InsertOrUpdate(Mapper.Map<Physique_BootConfig>(model));
        }

        public List<SubjectListDto> GetSubjects(int categoryId)
        {
            return (from c in this._physiqueSubjectRepository.GetAll() where c.CategoryId == categoryId select c)
                .ToList().Select(Mapper.Map<SubjectListDto>).ToList();

        }

        public SubjectDto GetSubject(int id)
        {
            return Mapper.Map<SubjectDto>(this._physiqueSubjectRepository.Get(id));
        }

        public void SaveSubject(SubjectDto model)
        {
            model.Scores = model.Score1.ToString() + "," + model.Score2.ToString() + "," + model.Score3.ToString() +
                           "," + model.Score4.ToString() + "," + model.Score5.ToString();
            this._physiqueSubjectRepository.InsertOrUpdate(Mapper.Map<Physique_Subject>(model));
        }

        public void DeleteSubject(int id)
        {
            this._physiqueSubjectRepository.Delete(id);
        }

        public DocumentDto GetDocument(int categoryId)
        {
            return Mapper.Map<DocumentDto>(
                (from c in this._physiqueDocumentRepository.GetAll()
                 where c.CategoryId == categoryId
                 orderby c.Id
                 select c)
                .FirstOrDefault(x => x.CategoryId == categoryId));
        }

        public void SaveDocument(DocumentDto model)
        {
            this._physiqueDocumentRepository.InsertOrUpdate(Mapper.Map<Physique_Document>(model));
        }
    }
}
