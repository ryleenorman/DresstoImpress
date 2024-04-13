// Emily Surface 
using DresstoImpressAPI2.Entities;
using System.Threading.Tasks;

namespace DresstoImpressAPI.Repositories
{
    public interface ITemperatureService
    {
        Task<List<GetTemperature>> GetTemperature(int WeatherID);
    }
}