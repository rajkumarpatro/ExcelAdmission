using Admission.Helpers;
using BusinessLogic;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Admission.Controllers
{
    public class AdmissionController : Controller
    {
        AdmissionBL _admissionBL;
        public AdmissionController()
        {
            _admissionBL = new AdmissionBL();
        }

        public ActionResult Index()
        {
           
            AdmissionModel AdmissionModel = new AdmissionModel();
            return View("AdmissionList", AdmissionModel);
        }
        public async Task<JsonResult> GetAdmissionList()
        {
            
            return Json(new { data = await _admissionBL.GetAdmissionList() }, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> AddAdmission(int? admissionId = null)
        {
            AdmissionModel model;

            if (admissionId != null)
            {
                model = await _admissionBL.GetAdmission(admissionId.Value);
            }
            else
            {
                model = new AdmissionModel();
                model.DOB = DateTime.Now;
                model.DATE_OF_JOINING = DateTime.Now;
            }

            return PartialView("Admission", model);
        }

        [HttpPost]
        public async Task<bool> AddAdmission(AdmissionModel admissionModel)
        {
            admissionModel.USER_ID = 3;

            if (admissionModel.A_ID > 0)
            {
                var exitingAdmission = await _admissionBL.GetAdmission(admissionModel.A_ID);

                if (Request.Files.Count > 0 && !(exitingAdmission.PHOTO ?? "").Equals(Request.Files[0].FileName))
                {
                    admissionModel.PHOTO = FileHandler.SaveUploadedFile(Request, "profile");
                    string fullPath = Request.MapPath(exitingAdmission.PHOTO);
                    if (System.IO.File.Exists(fullPath))
                    {
                        System.IO.File.Delete(fullPath);
                    }
                }
            }
            else
            {
                //save photo for new profile
                if (Request.Files.Count > 0)
                    admissionModel.PHOTO = FileHandler.SaveUploadedFile(Request, "admission");
            }

            return await _admissionBL.AddAdmission(admissionModel);
        }
        public async Task<JsonResult> GetAdmission(int AdmissionId)
        {
            return Json(await _admissionBL.GetAdmission(AdmissionId), JsonRequestBehavior.AllowGet);
        }

        public async Task<bool> DeleteAdmission(int AdmissionId)
        {
            return await _admissionBL.DeleteAdmission(AdmissionId);
        }

    }
}