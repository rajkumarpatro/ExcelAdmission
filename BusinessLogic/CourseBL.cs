using AutoMapper;
using DAL;
using DataModel;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CourseBL : Base
    {
        public async Task<List<CourseModel>> GetCourseList()
        {
            return Mapping.Mapper.Map<List<TBL_COURSE>, List<CourseModel>>(db.TBL_COURSE.ToList());
        }
        public async Task<CourseModel> GetCourse(int courseId)
        {
            return Mapping.Mapper.Map<TBL_COURSE, CourseModel>(db.TBL_COURSE.FirstOrDefault(x=> x.COURSE_ID == courseId));
        }

        public async Task<bool> AddCourse(CourseModel courseModel)
        {
            var course =  Mapping.Mapper.Map<CourseModel, TBL_COURSE>(courseModel);
            db.TBL_COURSE.AddOrUpdate(course);
            db.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteCourse(int courseId)
        {
            var course = db.TBL_COURSE.FirstOrDefault(x => x.COURSE_ID == courseId);
            db.TBL_COURSE.Remove(course);

            db.SaveChanges();
            return true;
        }
    }
}
