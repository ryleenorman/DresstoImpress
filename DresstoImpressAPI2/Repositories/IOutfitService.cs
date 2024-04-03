//By Emily Mago

using DresstoImpressAPI2.Entities;

namespace DresstoImpressAPI.Repositories
{
    public interface IOutfitService
    {
        public Task<List<Outfit>> GetOutfitDetails(int outfitid);
    }
}
