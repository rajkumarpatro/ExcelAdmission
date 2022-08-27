using AutoMapper;
using DAL.Models;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UsersBL : Base
    {
        public async Task<List<UsersModel>> GetUserList()
        {
            return Mapping.Mapper.Map<List<TblUser>, List<UsersModel>>(db.TblUsers.ToList());
        }

        public async Task<UsersModel> GetUser(int userId)
        {
            return Mapping.Mapper.Map<TblUser, UsersModel>(db.TblUsers.FirstOrDefault(x=> x.UserId == userId));
        }

        public async Task<bool> AddUsers(UsersModel UsersModel)
        {
            try
            {
                var course = Mapping.Mapper.Map<UsersModel, TblUser>(UsersModel);
                db.TblUsers.Update(course);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public async Task<bool> DeleteUser(int userId)
        {
            var course = db.TblUsers.FirstOrDefault(x => x.UserId == userId);
            db.TblUsers.Remove(course);

            db.SaveChanges();
            return true;
        }
    }
}
