using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DüzceÜniversitesi.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=Duyuru; integrated security=true;");
        }

        public DbSet<Announcement> announcements { get; set; }
        public DbSet<User> users { get; set; }
    }
}
