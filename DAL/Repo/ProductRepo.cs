using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ProductRepo : Repo, IRepo<ProductInfo, int, bool>
    {
        public bool Create(ProductInfo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProductInfo Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductInfo> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductInfo obj)
        {
            throw new NotImplementedException();
        }
    }
}
