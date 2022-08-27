using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblEnquiry
    {
        public int EId { get; set; }
        public string Student { get; set; }
        public string Contact { get; set; }
        public string Place { get; set; }
        public int? CourseId { get; set; }
        public bool? ModeOfClass { get; set; }
        public string Message { get; set; }
        public DateTime? Datetimestamp { get; set; }
    }
}
