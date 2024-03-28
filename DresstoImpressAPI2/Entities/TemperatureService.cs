﻿// Emily Surface 
using DresstoImpressAPI.Data;
using DresstoImpressAPI.Entities;
using DresstoImpressAPI.Repositories;
using DresstoImpressAPI2.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace DresstoImpressAPI.Repositories { }

public class TemperatureService : ITemperatureService
{
    private readonly DbContextClass _context;

    public TemperatureService(DbContextClass dbContextClass)
    {
        _context = dbContextClass;
    }

    public async Task<List<Weather>> GetTemperature(int WeatherID)
    {
        var param = new SqlParameter("@WeatherID", WeatherID);
        var temperatures = await _context.Weather
            .FromSqlRaw("EXEC GetTemperature @WeatherID", param)
            .ToListAsync();

        return temperatures;
    }
}
