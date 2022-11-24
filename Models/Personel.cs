using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

using System.Linq;
using System.Threading.Tasks;
namespace PersonelYonetim.Models
{
    public class Personel
    {

        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int tel { get; set; }
        public int unvanid { get; set; }
       


    }
}
