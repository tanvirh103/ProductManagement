using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo : Repo, IRepo<UserInfo, int, bool>
    {
        public bool Create(UserInfo obj)
        {
            db.UserInfos.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
           var data= db.UserInfos.Find(id);
                db.UserInfos.Remove(data);
                return db.SaveChanges() > 0;
        }

        public UserInfo Get(int id)
        {
            var data=db.UserInfos.Find(id);
            return data;
        }

        public List<UserInfo> GetAll()
        {
            return db.UserInfos.ToList();
          
        }

        public bool Update(UserInfo obj)
        {
            var ex = db.UserInfos.Find(obj.UserId);
            ex.UserName = obj.UserName;
            ex.Email = obj.Email;
            ex.Phone = obj.Phone;
            ex.Password = obj.Password;
            return db.SaveChanges()>0;

        }
    }
}
