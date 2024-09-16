﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        
        public string UserName { get; set; }
        [Required]
        [StringLength(30)]
      
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        
        public string Phone { get; set; }
        [Required]
        [StringLength(20)]
        
        public string Password { get; set; }
        [Required]
        [StringLength(20)]
        
        public string Role { get; set; }
    }
}
