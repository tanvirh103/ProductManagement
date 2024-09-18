using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]        
        public string ProductName { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductDescription { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        [Required]
        public int CId { get; set; }
    }
}
