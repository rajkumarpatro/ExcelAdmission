//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_ENQUIRY
    {
        public int E_ID { get; set; }
        public string STUDENT { get; set; }
        public string CONTACT { get; set; }
        public string PLACE { get; set; }
        public Nullable<int> COURSE_ID { get; set; }
        public Nullable<bool> MODE_OF_CLASS { get; set; }
        public string MESSAGE { get; set; }
        public Nullable<System.DateTime> DATETIMESTAMP { get; set; }
    }
}
