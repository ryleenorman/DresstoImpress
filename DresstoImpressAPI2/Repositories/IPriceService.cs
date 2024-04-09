//By Emily Mago

using DresstoImpressAPI2.Entities;
using System.Threading.Tasks;

namespace DresstoImpressAPI2.Repositories
{
    public interface IPriceService
    {
        Task<decimal?> GetPriceDetails(int clothingId);
    }
}
