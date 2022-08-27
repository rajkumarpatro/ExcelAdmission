using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblSubject
    {
        public int SubjectId { get; set; }
        public int? CourseId { get; set; }
        public string Subject { get; set; }
        public int? OfflineFees { get; set; }
        public int? OnlineFees { get; set; }
        public bool? Isactive { get; set; }

        public virtual TblCourse Course { get; set; }
    }
}
