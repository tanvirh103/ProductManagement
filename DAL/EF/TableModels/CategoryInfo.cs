using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.TableModels
{
    public class CategoryInfo
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName ="Varchar")]
        public string CategoryName { get; set; }
        [Required]
        [StringLength(200)]
        [Column(TypeName = "Varchar")]
        public string CategoryDescription { get; set; }
        public virtual ICollection<ProductInfo> ProductInfos { get; set; }
        public CategoryInfo() {
            ProductInfos = new List<ProductInfo>();
        }
    }
}
