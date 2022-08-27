using AutoMapper;
using DAL.Models;
using DataModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SubjectBL : Base
    {
        public async Task<List<SubjectModel>> GetSubjectList(int courseId)
        {
            var subject = db.TblSubjects.Where(x => x.CourseId == courseId).ToList();
            return Mapping.Mapper.Map<List<TblSubject>, List<SubjectModel>>(subject);
        }
        public async Task<SubjectModel> GetSbuject(int subjectId)
        {
            var subjectdetails = db.TblSubjects.FirstOrDefault(x => x.SubjectId == subjectId);
            return Mapping.Mapper.Map<TblSubject, SubjectModel>(subjectdetails);
        }
        
        public async Task<bool> AddSubject(SubjectModel subjectModel)
        {
            var subject =  Mapping.Mapper.Map<SubjectModel, TblSubject>(subjectModel);
            db.TblSubjects.Update(subject);
            db.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteSubject(int subjectId)
        {
            var subject = db.TblSubjects.FirstOrDefault(x => x.SubjectId == subjectId);
            db.TblSubjects.Remove(subject);

            db.SaveChanges();
            return true;
        }
    }
}
