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
    public class UsersController : Controller
    {
        UsersBL _userBL;
        BranchBL _branchBL;
        DesignationBL _designationBL;
        public UsersController()
        {
            _userBL = new UsersBL();
            _branchBL = new BranchBL();
            _designationBL = new DesignationBL();
        }

        public ActionResult Index()
        {
            return View("UsersList");
        }

        public async Task<ActionResult> AddUser(int? userId = null)
        {
            UsersModel model;

            if (userId != null)
            {
                model = await _userBL.GetUser(userId.Value);
            }
            else
            {
                model = new UsersModel();
                model.DOB = DateTime.Now;
            }

            var branch = await _branchBL.GetBranchList();
            model.BranchDD = branch.Select(x => new SelectListItem { Text = x.BRANCH, Value = x.BRANCH_ID.ToString() }).ToList();
            var designation = await _designationBL.GetDesignationList();
            model.DesignationDD = designation.Select(x => new SelectListItem { Text = x.DESIGNATION, Value = x.DESIGNATION_ID.ToString() }).ToList();

            return PartialView("User", model);
        }
        [HttpPost]
        public async Task<bool> AddUser(UsersModel UsersModel)
        {
            return await _userBL.AddUsers(UsersModel);
        }

        public async Task<JsonResult> GetUserList()
        {
            return Json(new { data = await _userBL.GetUserList() }, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> GetUser(int UserId)
        {
            return Json(await _userBL.GetUser(UserId), JsonRequestBehavior.AllowGet);
        }

        public async Task<bool> DeleteUser(int UserId)
        {
            return await _userBL.DeleteUser(UserId);
        }
    }
}