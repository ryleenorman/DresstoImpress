//By Emily Mago

using DresstoImpressAPI2.Entities;

namespace DresstoImpressAPI2.Repositories
{
    public interface IPriceService
    {
        public Task<List<Clothing>> GetPriceDetails(int clothingid);

    }
}