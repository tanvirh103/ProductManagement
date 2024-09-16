using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.TableModels
{
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName ="Varchar")]
        public string UserName { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "Varchar")]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string Phone { get; set; }
        [Required]
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string Password { get; set; }
        [Required]
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string Role { get; set; }
    }
}
