using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataModel
{
    public class AdmissionModel
    {
        public int A_ID { get; set; }
        public DateTime? DATE_OF_JOINING { get; set; }
        public string APPEARING_FOR { get; set; }
        public int? APPEARING_YEAR { get; set; }
        public string STUDENT_NAME { get; set; }
        public DateTime? DOB { get; set; }
        public string FATHER { get; set; }
        public string MOTHER { get; set; }
        public string STUDENT_CONTACT { get; set; }
        public string STUDENT_TELEGRAM { get; set; }
        public string STUDENT_EMAIL { get; set; }
        public string PARENT_CONTACT { get; set; }
        public string PARENT_TELEGRAM { get; set; }
        public string PARENT_EMAIL { get; set; }
        public string PERMANENT_ADDRESS { get; set; }
        public string PERMANENT_DISTRICT { get; set; }
        public string PERMANENT_PINCODE { get; set; }
        public string RESIDENTIAL_ADDRESS { get; set; }
        public string RESIDENTIAL_DISTRICT { get; set; }
        public string RESIDENTIAL_PINCODE { get; set; }
        public decimal? MARKS_10TH { get; set; }
        public decimal? MARKS_11TH { get; set; }
        public decimal? MARKS_12TH { get; set; }
        public bool? MEDIUM { get; set; }
        public string SCHOOL_COLLLEGE { get; set; }
        public int? CAME_THROUGH_ID { get; set; }
        public int? TOTAL_FEES { get; set; }
        public decimal? DISCOUNT_PERCENT { get; set; }
        public decimal? DISCOUNT_RUPEES { get; set; }
        public bool? PART_PAYMENT { get; set; }
        public bool? FEES_PAID { get; set; }
        public System.DateTime? PAYMENT_DATE { get; set; }
        public string TRANSACTION_ID { get; set; }
        public decimal? PAID_AMOUNT { get; set; }
        public bool? ISACTIVE { get; set; }
        public int USER_ID { get; set; }
        public string PHOTO { get; set; }
        public string FATHER_OCCUPATION { get; set; }
        public string MOTHER_OCCUPATION { get; set; }
    }
}
