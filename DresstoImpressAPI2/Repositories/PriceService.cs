//By Emily Mago

using DresstoImpressAPI2.Data;
using DresstoImpressAPI2.Entities;
using DresstoImpressAPI2.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DresstoImpressAPI2.Repositories
{
    public class PriceService : IPriceService
    {
        private readonly DbContextClass _dbContextClass;

        public PriceService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<decimal?> GetPriceDetails(int clothingId)
        {
            var clothing = await _dbContextClass.Clothing.FirstOrDefaultAsync(c => c.ClothingID == clothingId);

            if (clothing == null)
            {
                return null;
            }

            return clothing.Price;
        }
    }
}
