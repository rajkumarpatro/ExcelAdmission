using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public partial class UsersModel
    {
		public int USER_ID { get; set; }
		public string USER_NAME { get; set; }
		public int DESIGNATION_ID { get; set; }
		public int BRANCH_ID { get; set; }
		public DateTime DOB { get; set; }
		public string CONTACT1 { get; set; }
		public string CONTACT2 { get; set; }
		public string EMAIL_ID { get; set; }
		public string ADDRESS { get; set; }
		public string PASSWORD { get; set; }
		public bool ISACTIVE { get; set; }
	}
}
