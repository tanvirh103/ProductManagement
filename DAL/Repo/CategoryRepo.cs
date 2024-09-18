using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class CategoryRepo : Repo, IRepo<CategoryInfo, int, bool>
    {
        public bool Create(CategoryInfo obj)
        {
            db.CategoryInfos.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            var data = db.CategoryInfos.Find(id);
            db.CategoryInfos.Remove(data);
            return db.SaveChanges() > 0;
        }

        public CategoryInfo Get(int id)
        {
            var data = db.CategoryInfos.Find(id);
            return data;
        }

        public List<CategoryInfo> GetAll()
        {
            var data = db.CategoryInfos.ToList();
            return data;
        }

        public bool Update(CategoryInfo obj)
        {
           var exobj=db.CategoryInfos.Find(obj.CategoryID);
            exobj.CategoryName = obj.CategoryName;
            exobj.CategoryDescription = obj.CategoryDescription;
            return db.SaveChanges()>0;
        }
    }
}
