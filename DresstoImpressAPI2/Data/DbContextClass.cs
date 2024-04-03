using DresstoImpressAPI2.Entities;
using Microsoft.EntityFrameworkCore;

namespace DresstoImpressAPI2.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {

        }
        public DbSet<Outfit> Outfit { get; set; }
        public DbSet<ClothingBySeason> ClothingBySeason { get; set; }
        public DbSet<WeatherByType> WeatherByType { get; set; }
        public DbSet<Weather> Weather { get; set; }

        public DbSet<USERS> USERS { get; set; }
        public DbSet<Clothing> Clothing { get; set; }
    }
}
