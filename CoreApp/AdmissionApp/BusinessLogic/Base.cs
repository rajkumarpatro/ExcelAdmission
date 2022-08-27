using DAL;
using DAL.Models;

namespace BusinessLogic
{
    public class Base
    {
        public db_exceladContext db { get; set; } = new db_exceladContext();
    }
}
