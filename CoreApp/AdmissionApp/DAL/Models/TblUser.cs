using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblAdmissions = new HashSet<TblAdmission>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public int? DesignationId { get; set; }
        public int? BranchId { get; set; }
        public bool? Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string FatherName { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool? Isactive { get; set; }
        public string Photo { get; set; }

        public virtual TblBranch Branch { get; set; }
        public virtual TblDesignation Designation { get; set; }
        public virtual ICollection<TblAdmission> TblAdmissions { get; set; }
    }
}
