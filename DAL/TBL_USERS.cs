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
    
    public partial class TBL_USERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_USERS()
        {
            this.TBL_ADMISSION = new HashSet<TBL_ADMISSION>();
        }
    
        public int USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public Nullable<int> DESIGNATION_ID { get; set; }
        public Nullable<int> BRANCH_ID { get; set; }
        public Nullable<bool> GENDER { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string FATHER_NAME { get; set; }
        public string CONTACT1 { get; set; }
        public string CONTACT2 { get; set; }
        public string EMAIL_ID { get; set; }
        public string ADDRESS { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<bool> ISACTIVE { get; set; }
        public string PHOTO { get; set; }
    
        public virtual TBL_BRANCH TBL_BRANCH { get; set; }
        public virtual TBL_DESIGNATION TBL_DESIGNATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_ADMISSION> TBL_ADMISSION { get; set; }
    }
}
