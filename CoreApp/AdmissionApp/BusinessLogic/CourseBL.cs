using AutoMapper;
using DAL.Models;
using DataModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CourseBL : Base
    {
        public async Task<List<CourseModel>> GetCourseList()
        {
            return Mapping.Mapper.Map<List<TblCourse>, List<CourseModel>>(db.TblCourses.ToList());
        }
        public async Task<CourseModel> GetCourse(int courseId)
        {
            return Mapping.Mapper.Map<TblCourse, CourseModel>(db.TblCourses.FirstOrDefault(x=> x.CourseId == courseId));
        }

        public async Task<bool> AddCourse(CourseModel courseModel)
        {
            var course =  Mapping.Mapper.Map<CourseModel, TblCourse>(courseModel);
            db.TblCourses.Update(course);
            db.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteCourse(int courseId)
        {
            var course = db.TblCourses.FirstOrDefault(x => x.CourseId == courseId);
            db.TblCourses.Remove(course);

            db.SaveChanges();
            return true;
        }
    }
}
