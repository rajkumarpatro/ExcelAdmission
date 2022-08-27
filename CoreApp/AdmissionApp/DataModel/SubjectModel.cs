using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace DataModel
{
    public class SubjectModel
    {
        public int SUBJECT_ID { get; set; }
        public Nullable<int> COURSE_ID { get; set; }
        public string SUBJECT { get; set; }
        public Nullable<int> OFFLINE_FEES { get; set; }
        public Nullable<int> ONLINE_FEES { get; set; }
        public Nullable<bool> ISACTIVE { get; set; } = true;

        public List<SelectListItem> COURSE_LIST { get; set; } = new List<SelectListItem>();

    }
}
