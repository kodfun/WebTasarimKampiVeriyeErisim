using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteriEf.Models
{
    public class AdresDefteriContext : DbContext
    {
        public AdresDefteriContext()
        {
            Database.EnsureCreated(); // veritabanı yoksa oluştur
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=AdresDefteriEFDB; Trusted_Connection=True;");
        }

        public DbSet<Kisi> Kisiler { get; set; }
    }
}
