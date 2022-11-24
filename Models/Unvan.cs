using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

using System.Linq;
using System.Threading.Tasks;
namespace PersonelYonetim.Models
{
    public class Unvan
    {

        [Key]
        public int id { get; set; }
        public string unvanad { get; set; }
        public string personelid { get; set; }
       

    }
}
