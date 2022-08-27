using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblCourse
    {
        public TblCourse()
        {
            TblSubjects = new HashSet<TblSubject>();
        }

        public int CourseId { get; set; }
        public string Course { get; set; }
        public int? OfflineFees { get; set; }
        public int? OnlineFees { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<TblSubject> TblSubjects { get; set; }
    }
}
