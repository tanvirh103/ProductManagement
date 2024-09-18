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
    public class ProductService
    {
        public static Mapper GetMapper() {
            var con = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductInfo, ProductDTO>();
                cfg.CreateMap<ProductDTO, ProductInfo>();
            });
            return new Mapper(con);
        }
        public static bool Create(ProductDTO d) {
            var data = GetMapper().Map<ProductInfo>(d);
            return DataAccessFactory.ProductData().Create(data);
        }
        public static bool Update(ProductDTO d) {
            var data= GetMapper().Map<ProductInfo>(d);
            return DataAccessFactory.ProductData().Update(data);
        }

        public static bool Delete(int d) {
            return DataAccessFactory.ProductData().Delete(d);
        }
        public static ProductDTO Get(int d) {
            var product=DataAccessFactory.ProductData().Get(d);
            var data = GetMapper().Map<ProductDTO>(product);
            return data;
        }
        public static List<ProductDTO> GetAll() {
            var data=DataAccessFactory.ProductData().GetAll();
            var con = GetMapper().Map<List<ProductDTO>>(data);
            return con;
        }
    }
}
