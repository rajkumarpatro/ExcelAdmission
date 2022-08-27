using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public partial class CourseModel
    {
        public int COURSE_ID { get; set; }
        public string COURSE { get; set; }
        public int? OFFLINE_FEES { get; set; }
        public int? ONLINE_FEES { get; set; }
        public bool? ISACTIVE { get; set; } = true;
    }
}
