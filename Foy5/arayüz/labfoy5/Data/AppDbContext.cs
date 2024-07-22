using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using labfoy5.Models;
using YourNamespace.Models;

namespace labfoy5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
    }
}
