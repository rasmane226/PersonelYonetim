
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

using System.Linq;
using System.Threading.Tasks;
namespace PersonelYonetim.Models
{
    public class Admin
    {
        [Key]
        [Required]
        public int AdminID { get; set; }

        [Column(TypeName ="varchar(20)")]
        public string Kullanici { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Sifre { get; set; }

    }
}
