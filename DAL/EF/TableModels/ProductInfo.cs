using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.TableModels
{
    public class ProductInfo
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName ="Varchar")]
        public string ProductName { get; set; }
        [Required]
        [StringLength(200)]
        [Column(TypeName = "Varchar")]
        public string ProductDescription { get; set; }
        [Required]
        [Column(TypeName = "Int")]
        public int Quantity { get; set; }
        [Required]
        [Column(TypeName ="Float")]
        public double ProductPrice { get; set; }
        public virtual CategoryInfo CategoryInfo { get; set; }
        [ForeignKey("CategoryInfo")]
        public int CategoryId { get; set; }
    }
}
