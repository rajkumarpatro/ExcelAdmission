using AutoMapper;
using DAL;
using DataModel;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DesignationBL : Base
    {
        public async Task<List<DesignationModel>> GetDesignationList()
        {
            return Mapping.Mapper.Map<List<TBL_DESIGNATION>, List<DesignationModel>>(db.TBL_DESIGNATION.ToList());
        }

        public async Task<DesignationModel> GetDesignation(int DesignationId)
        {
            return Mapping.Mapper.Map<TBL_DESIGNATION, DesignationModel>(db.TBL_DESIGNATION.FirstOrDefault(x=> x.DESIGNATION_ID == DesignationId));
        }

        public async Task<bool> AddDesignation(DesignationModel DesignationModel)
        {
            var Designation =  Mapping.Mapper.Map<DesignationModel, TBL_DESIGNATION>(DesignationModel);
            db.TBL_DESIGNATION.AddOrUpdate(Designation);
            db.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteDesignation(int DesignationId)
        {
            var Designation = db.TBL_DESIGNATION.FirstOrDefault(x => x.DESIGNATION_ID == DesignationId);
            db.TBL_DESIGNATION.Remove(Designation);

            db.SaveChanges();
            return true;
        }
    }
}
