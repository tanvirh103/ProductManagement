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
            db.ProductInfos.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            var data = db.ProductInfos.Find(id);
            db.ProductInfos.Remove(data);
            return db.SaveChanges()>0;
        }

        public ProductInfo Get(int id)
        {
            return db.ProductInfos.Find(id);
        }

        public List<ProductInfo> GetAll()
        {
            return db.ProductInfos.ToList();
        }

        public bool Update(ProductInfo obj)
        {
            var exobj = db.ProductInfos.Find(obj.ProductId);
            exobj.ProductName = obj.ProductName;
            exobj.ProductDescription = obj.ProductDescription;
            exobj.ProductPrice = obj.ProductPrice;
            return db.SaveChanges() > 0;
        }
    }
}
