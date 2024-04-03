using DresstoImpressAPI2.Data;
using DresstoImpressAPI2.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DresstoImpressAPI2.Repositories
{
    public class ClothingSeasonService : IClothingSeasonService
    {
        private readonly DbContextClass _dbContextClass;
        public ClothingSeasonService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<ClothingBySeason>> GetClothingbySeason(int ClothingID)
        {
            var param = new SqlParameter("@ClothingID", ClothingID);
            var getClothingbySeason = await Task.Run(() => _dbContextClass.ClothingBySeason.FromSqlRaw("exec GetClothingbySeason @ClothingID", param).ToListAsync());
            return getClothingbySeason;
        }
    }
}