using AutoMapper;
using DAL.Models;
using DataModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DesignationBL : Base
    {
        public async Task<List<DesignationModel>> GetDesignationList()
        {
            return Mapping.Mapper.Map<List<TblDesignation>, List<DesignationModel>>(db.TblDesignations.ToList());
        }

        public async Task<DesignationModel> GetDesignation(int DesignationId)
        {
            return Mapping.Mapper.Map<TblDesignation, DesignationModel>(db.TblDesignations.FirstOrDefault(x=> x.DesignationId == DesignationId));
        }

        public async Task<bool> AddDesignation(DesignationModel DesignationModel)
        {
            var Designation =  Mapping.Mapper.Map<DesignationModel, TblDesignation>(DesignationModel);
            db.TblDesignations.Update(Designation);
            db.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteDesignation(int DesignationId)
        {
            var Designation = db.TblDesignations.FirstOrDefault(x => x.DesignationId == DesignationId);
            db.TblDesignations.Remove(Designation);

            db.SaveChanges();
            return true;
        }
    }
}
