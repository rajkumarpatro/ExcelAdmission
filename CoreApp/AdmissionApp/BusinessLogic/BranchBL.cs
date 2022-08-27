using DAL.Models;
using DataModel;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BranchBL : Base
    {
        public async Task<List<BranchModel>> GetBranchList()
        {
            return Mapping.Mapper.Map<List<TblBranch>, List<BranchModel>>(db.TblBranches.ToList());
        }
        public async Task<BranchModel> GetBranch(int BranchId)
        {
            return Mapping.Mapper.Map<TblBranch, BranchModel>(db.TblBranches.FirstOrDefault(x=> x.BranchId == BranchId));
        }

        public async Task<bool> AddBranch(BranchModel BranchModel)
        {
            var Branch =  Mapping.Mapper.Map<BranchModel, TblBranch>(BranchModel);
            db.TblBranches.Update(Branch);
            db.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteBranch(int BranchId)
        {
            var Branch = db.TblBranches.FirstOrDefault(x => x.BranchId == BranchId);
            db.TblBranches.Remove(Branch);

            db.SaveChanges();
            return true;
        }
    }
}
