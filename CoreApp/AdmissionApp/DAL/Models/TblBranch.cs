using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblBranch
    {
        public TblBranch()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public int BranchId { get; set; }
        public string Branch { get; set; }

        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
