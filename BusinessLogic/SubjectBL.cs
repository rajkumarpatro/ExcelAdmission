using AutoMapper;
using DAL;
using DataModel;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SubjectBL : Base
    {
        public async Task<List<SubjectModel>> GetSubjectList(int courseId)
        {
            var subject = db.TBL_SUBJECTS.Where(x => x.COURSE_ID == courseId).ToList();
            return Mapping.Mapper.Map<List<TBL_SUBJECTS>, List<SubjectModel>>(subject);
        }
        public async Task<SubjectModel> GetSbuject(int subjectId)
        {
            var subjectdetails = db.TBL_SUBJECTS.FirstOrDefault(x => x.SUBJECT_ID == subjectId);
            return Mapping.Mapper.Map<TBL_SUBJECTS, SubjectModel>(subjectdetails);
        }
        
        public async Task<bool> AddSubject(SubjectModel subjectModel)
        {
            var subject =  Mapping.Mapper.Map<SubjectModel, TBL_SUBJECTS>(subjectModel);
            db.TBL_SUBJECTS.AddOrUpdate(subject);
            db.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteSubject(int subjectId)
        {
            var subject = db.TBL_SUBJECTS.FirstOrDefault(x => x.SUBJECT_ID == subjectId);
            db.TBL_SUBJECTS.Remove(subject);

            db.SaveChanges();
            return true;
        }
    }
}
