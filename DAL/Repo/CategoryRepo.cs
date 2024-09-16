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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryInfo Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryInfo> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(CategoryInfo obj)
        {
            throw new NotImplementedException();
        }
    }
}
