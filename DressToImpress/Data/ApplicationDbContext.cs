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
        public DbSet<DresstoImpressAPI2.Entities.Weather> Weather { get; set; } = default!;
        public DbSet<DresstoImpressAPI2.Entities.ClothingBySeason> ClothingBySeason { get; set; } = default!;
        public DbSet<DresstoImpressAPI2.Entities.USERS> USERS { get; set; } = default!;
        public DbSet<DresstoImpressAPI2.Entities.WeatherByType> WeatherByType { get; set; } = default!;
        public DbSet<DresstoImpressAPI2.Entities.Cart> Cart { get; set; } = default!;
    }
}
