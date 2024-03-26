﻿//Rylee Norman

using DresstoImpressAPI.Data;
using DresstoImpressAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DresstoImpressAPI.Repositories
{
    public class OutfitService : IOutfitService
    {
        private readonly DbContextClass _dbContextClass;
        public OutfitService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Outfit>> GetOutfitDetails(int OutfitID)
        {
            var param = new SqlParameter("@OutfitID", OutfitID);
            var getOutfitDetails = await Task.Run(() => _dbContextClass.Outfit.FromSqlRaw("exec GetOutfitDetails @OutfitID", param).ToListAsync());
            return getOutfitDetails;
        }

    }
}
