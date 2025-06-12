using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CAR.ADMIN.Models
{
   
    public class AppDbContext:DbContext
    {
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public AppDbContext()
            :base("name=DefaultConnection")
        {
            
        }
    }
}