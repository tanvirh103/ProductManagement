using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CategoryDTO
    {  
        public int CategoryID { get; set; }
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }
        [Required]
        [StringLength(200)]
        public string CategoryDescription { get; set; }
    }
}
