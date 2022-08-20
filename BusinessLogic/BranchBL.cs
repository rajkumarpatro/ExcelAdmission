using AutoMapper;
using DAL;
using DataModel;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BranchBL : Base
    {
        public async Task<List<BranchModel>> GetBranchList()
        {
            return Mapping.Mapper.Map<List<TBL_BRANCH>, List<BranchModel>>(db.TBL_BRANCH.ToList());
        }
        public async Task<BranchModel> GetBranch(int BranchId)
        {
            return Mapping.Mapper.Map<TBL_BRANCH, BranchModel>(db.TBL_BRANCH.FirstOrDefault(x=> x.BRANCH_ID == BranchId));
        }

        public async Task<bool> AddBranch(BranchModel BranchModel)
        {
            var Branch =  Mapping.Mapper.Map<BranchModel, TBL_BRANCH>(BranchModel);
            db.TBL_BRANCH.AddOrUpdate(Branch);
            db.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteBranch(int BranchId)
        {
            var Branch = db.TBL_BRANCH.FirstOrDefault(x => x.BRANCH_ID == BranchId);
            db.TBL_BRANCH.Remove(Branch);

            db.SaveChanges();
            return true;
        }
    }
}
