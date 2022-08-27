using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblDesignation
    {
        public TblDesignation()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public int DesignationId { get; set; }
        public string Designation { get; set; }

        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
