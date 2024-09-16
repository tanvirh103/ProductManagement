using DAL.EF.TableModels;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<UserInfo, int, bool> UserData() {
            return new UserRepo();
        }
        public static IRepo<ProductInfo, int, bool> ProductData() {
            return new ProductRepo();
        }
        public static IRepo<CategoryInfo, int, bool> CategoryData() {
        return new CategoryRepo();
        }
    }
}
