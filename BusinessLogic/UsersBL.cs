using AutoMapper;
using DAL;
using DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UsersBL : Base
    {
        public async Task<List<UsersModel>> GetUserList()
        {
            return Mapping.Mapper.Map<List<TBL_USERS>, List<UsersModel>>(db.TBL_USERS.ToList());
        }

        public async Task<UsersModel> GetUser(int userId)
        {
            return Mapping.Mapper.Map<TBL_USERS, UsersModel>(db.TBL_USERS.FirstOrDefault(x=> x.USER_ID == userId));
        }

        public async Task<bool> AddUsers(UsersModel UsersModel)
        {
            try
            {
                var course = Mapping.Mapper.Map<UsersModel, TBL_USERS>(UsersModel);
                db.TBL_USERS.AddOrUpdate(course);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public async Task<bool> DeleteUser(int userId)
        {
            var course = db.TBL_USERS.FirstOrDefault(x => x.USER_ID == userId);
            db.TBL_USERS.Remove(course);

            db.SaveChanges();
            return true;
        }
    }
}
