using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonelYonetim.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BIM-TEKNIK-SERV;database=personelYonetim;integrated security=true;");
        }
        public DbSet<Personel> personels { get; set; }
        public DbSet<Unvan> Unvans { get; set; }
      
        public DbSet<Admin> admins{ get; set; }
        public DbSet<Kayit> kayits{ get; set; }

    }
}
