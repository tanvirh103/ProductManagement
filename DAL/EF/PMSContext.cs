using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class PMSContext:DbContext
    {
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<ProductInfo> ProductInfos { get; set; }
        public DbSet<CategoryInfo> CategoryInfos { get; set; }
    }
}
