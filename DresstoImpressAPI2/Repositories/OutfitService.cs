//By Emily Mago

using DresstoImpressAPI2.Data;
using DresstoImpressAPI2.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DresstoImpressAPI.Repositories
{
    public class OutfitService : IOutfitService
    {
        private readonly DbContextClass _dbContextClass;
        public OutfitService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Outfit>> GetOutfitDetails(int outfitid)
        {
            var param = new SqlParameter("@OutfitID", outfitid);
            var OutfitDetails = await _dbContextClass.Outfit.FromSqlRaw("exec GetOutfitDetails @OutfitID", param).ToListAsync();
            return OutfitDetails;


        }
        


    }
}