using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class UsersModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int? DesignationId { get; set; }
        public int? BranchId { get; set; }
        public bool? Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string FatherName { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool? Isactive { get; set; }
        public string Photo { get; set; }
        public List<SelectListItem> BranchDD { get; set; }
        public List<SelectListItem> DesignationDD { get; set; }
    }
}
