using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DresstoImpressAPI2.Entities;

namespace DresstoImpress.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DresstoImpressAPI2.Entities.Clothing> Clothing { get; set; } = default!;
    }
}
