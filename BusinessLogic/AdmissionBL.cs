using AutoMapper;
using DAL;
using DataModel;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AdmissionBL : Base
    {
        public async Task<List<AdmissionModel>> GetAdmissionList()
        {
            return Mapping.Mapper.Map<List<TBL_ADMISSION>, List<AdmissionModel>>(db.TBL_ADMISSION.ToList());
        }
        public async Task<AdmissionModel> GetAdmission(int aId)
        {
            return Mapping.Mapper.Map<TBL_ADMISSION, AdmissionModel>(db.TBL_ADMISSION.FirstOrDefault(x=> x.A_ID == aId));
        }

        public async Task<bool> AddAdmission(AdmissionModel AdmissionModel)
        {
            var admission =  Mapping.Mapper.Map<AdmissionModel, TBL_ADMISSION>(AdmissionModel);
            db.TBL_ADMISSION.AddOrUpdate(admission);
            db.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteAdmission(int aId)
        {
            var admission = db.TBL_ADMISSION.FirstOrDefault(x => x.A_ID == aId);
            db.TBL_ADMISSION.Remove(admission);

            db.SaveChanges();
            return true;
        }
    }
}
