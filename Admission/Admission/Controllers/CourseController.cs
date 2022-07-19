using BusinessLogic;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Admission.Controllers
{
    public class CourseController : Controller
    {
        CourseBL _courseBL;
        public CourseController()
        {
            _courseBL = new CourseBL(); 
        }
        public ActionResult Index()
        {
            CourseModel courseModel = new CourseModel();
            return View("Course", courseModel);
        }

        [HttpPost]
        public async Task<bool> AddCourse(CourseModel courseModel)
        {
            return await _courseBL.AddCourse(courseModel);
        }

        public async Task<JsonResult> GetCourseList() { 
            return Json(new { data = await _courseBL.GetCourseList() }, JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> GetCourseListById(int courseId)
        {
            return Json(await _courseBL.GetCourseList(courseId), JsonRequestBehavior.AllowGet);
        }

        public async Task<bool> DeleteCourse(int courseId)
        {
            return await _courseBL.DeleteCourse(courseId);
        }

    }
}