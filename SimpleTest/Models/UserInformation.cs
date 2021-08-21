using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTest.Models
{
    public class UserInformation
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Full Name")]
        [Required]
        public string name { get; set; }
        [DisplayName("Phone Number")]
        [Required]
        public int phoneNumber { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Email")]
        [Required]
        public string email { get; set; }
    }
}
