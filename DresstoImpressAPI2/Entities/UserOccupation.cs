﻿// Emily Surface 
using DresstoImpressAPI.Data;
using DresstoImpressAPI.Entities;
using DresstoImpressAPI2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DresstoImpressAPI.Repositories
{
    public class UserOccupationService : IUserOccupationService
    {
        private readonly DbContextClass _context;


        public UserOccupationService(DbContextClass dbContextClass)
        {
            _context = dbContextClass;
        }

        public async Task<List<USERS>> GetUserOccupation(int UserID)
        {
            var param = new SqlParameter("@UserID", UserID);
            var userOccupation = await _context.Users
                .FromSqlRaw("EXEC SeeOccupation @UserID", param)
                .ToListAsync();

            return userOccupation;
        }

    }
}