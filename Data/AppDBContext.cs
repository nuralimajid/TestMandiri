using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestMandiri.Models;

namespace TestMandiri.Data
{
    public class AppDBContext : IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Buku> Buku { get; set; }
        public DbSet<Penulis> Penulis { get; set;}
        public DbSet<Kategori> Kategori { get; set; }

       
    }
}
