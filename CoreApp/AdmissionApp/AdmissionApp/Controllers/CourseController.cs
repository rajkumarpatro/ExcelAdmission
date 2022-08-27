﻿using BusinessLogic;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

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
            //return Json(new { data = await _courseBL.GetCourseList() }, JsonRequestBehavior.AllowGet);
            return Json(new { data = await _courseBL.GetCourseList() });
        }
        public async Task<JsonResult> GetCourse(int courseId)
        {
            return Json(await _courseBL.GetCourse(courseId));
        }

        public async Task<bool> DeleteCourse(int courseId)
        {
            return await _courseBL.DeleteCourse(courseId);
        }

    }
}