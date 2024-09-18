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
    public class CategoryService
    {
        public static Mapper GetMapper()
        {
            var con = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CategoryDTO, CategoryInfo>();
                cfg.CreateMap<CategoryInfo, CategoryDTO>();
            });
            return new Mapper(con);
        }
        public static bool Create(CategoryDTO c) {
            var Conv = GetMapper().Map<CategoryInfo>(c);
            return DataAccessFactory.CategoryData().Create(Conv);
        }

        public static bool Delete(int id) {
            return DataAccessFactory.CategoryData().Delete(id);
        }
        public static CategoryDTO Get(int id) {
            var data=DataAccessFactory.CategoryData().Get(id);
            var con=GetMapper().Map<CategoryDTO>(data);
            return con;
        }
        public static List<CategoryDTO> GetAll() {
            var data=DataAccessFactory.CategoryData().GetAll();
            var con=GetMapper().Map<List<CategoryDTO>>(data);
            return con;
        }
        public static bool Update(CategoryDTO c) {
            var data=GetMapper().Map<CategoryInfo>(c);
            return DataAccessFactory.CategoryData().Update(data);
        }
    }
}
