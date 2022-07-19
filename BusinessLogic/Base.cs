using DAL;

namespace BusinessLogic
{
    public class Base
    {
        public db_exceladEntities db { get; set; } = new db_exceladEntities();
    }
}
