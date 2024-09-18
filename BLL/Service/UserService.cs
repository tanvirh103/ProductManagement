using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class UserService
    {
        public static Mapper GetMapper() {
            var con = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, UserInfo>();
                cfg.CreateMap<UserInfo, UserInfo>();
            });
            return new Mapper(con);
        }
        public static bool Create(UserDTO d) {
            var result = GetMapper().Map<UserInfo>(d);
            return DataAccessFactory.UserData().Create(result);
        }
        public static bool Update(UserDTO d) {
            var data=GetMapper().Map<UserInfo>(d);
            return DataAccessFactory.UserData().Update(data);
        }
        public static bool Delete(int d) {
            return DataAccessFactory.UserData().Delete(d);
        }
        public static UserDTO Get(int i) {
            var data= DataAccessFactory.UserData().Get(i);
            var con= GetMapper().Map<UserDTO>(i);
            return con;
        }
        public static List<UserDTO> GetAll() {
            var data = DataAccessFactory.UserData().GetAll();
            var con = GetMapper().Map<List<UserDTO>>(data);
            return con;
        }
    }
}
