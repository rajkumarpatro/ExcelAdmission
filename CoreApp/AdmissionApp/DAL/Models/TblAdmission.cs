using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblAdmission
    {
        public int AId { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string AppearingFor { get; set; }
        public int? AppearingYear { get; set; }
        public string StudentName { get; set; }
        public DateTime? Dob { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public string StudentContact { get; set; }
        public string StudentTelegram { get; set; }
        public string StudentEmail { get; set; }
        public string ParentContact { get; set; }
        public string ParentTelegram { get; set; }
        public string ParentEmail { get; set; }
        public string PermanentAddress { get; set; }
        public string PermanentDistrict { get; set; }
        public string PermanentPincode { get; set; }
        public string ResidentialAddress { get; set; }
        public string ResidentialDistrict { get; set; }
        public string ResidentialPincode { get; set; }
        public decimal? Marks10th { get; set; }
        public decimal? Marks11th { get; set; }
        public decimal? Marks12th { get; set; }
        public bool? Medium { get; set; }
        public string SchoolColllege { get; set; }
        public int? CameThroughId { get; set; }
        public int? TotalFees { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountRupees { get; set; }
        public bool? PartPayment { get; set; }
        public bool? FeesPaid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string TransactionId { get; set; }
        public decimal? PaidAmount { get; set; }
        public bool? Isactive { get; set; }
        public int UserId { get; set; }

        public virtual TblUser User { get; set; }
    }
}
