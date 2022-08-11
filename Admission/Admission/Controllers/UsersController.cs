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
        UsersBL _UserBL;
        public UsersController()
        {
            _UserBL = new UsersBL();
        }

        public ActionResult Index()
        {
            UsersModel UsersModel = new UsersModel();
            return View("Users", UsersModel);
        }

        [HttpPost]
        public async Task<bool> AddUser(UsersModel UsersModel)
        {
            return await _UserBL.AddUsers(UsersModel);
        }

        public async Task<JsonResult> GetUserList()
        {
            return Json(new { data = await _UserBL.GetUserList() }, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> GetUser(int UserId)
        {
            return Json(await _UserBL.GetUser(UserId), JsonRequestBehavior.AllowGet);
        }

        public async Task<bool> DeleteUser(int UserId)
        {
            return await _UserBL.DeleteUser(UserId);
        }
    }
}