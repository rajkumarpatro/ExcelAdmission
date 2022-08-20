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
    public class SubjectController : Controller
    {
        // GET: Subject
        SubjectBL _subjectBL;
        CourseBL _courseBL; 
        public SubjectController()
        {
            _subjectBL = new SubjectBL();
            _courseBL = new CourseBL();
        }
        public async Task<ActionResult> Index()
        {
            SubjectModel ob = new SubjectModel();

            var course =await _courseBL.GetCourseList();
            ob.COURSE_LIST = course.Select(x => new SelectListItem
            {
                Text = x.COURSE,
                Value = x.COURSE_ID.ToString()
            }).ToList();

            return View("Subject",ob);
        }

        [HttpPost]
        public async Task<bool>AddSubject(SubjectModel subjectModel)
        {
            return await _subjectBL.AddSubject(subjectModel);
        }

        public async Task<JsonResult>GetSubjectList(int courseId)
        {
            return Json(new { data = await _subjectBL.GetSubjectList(courseId) }, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult>GetSubjectListByID(int subjectId)
        {
            return Json( await _subjectBL.GetSbuject(subjectId), JsonRequestBehavior.AllowGet);
        }

        public async Task<bool> DeleteSubject(int subjectId)
        {
            return await _subjectBL.DeleteSubject(subjectId);
        }
    }
}