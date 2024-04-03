// Emily Surface 
using DresstoImpressAPI2.Entities;
using System.Threading.Tasks;

namespace DresstoImpressAPI2.Repositories
{
    public interface IUserOccupationService
    {
        Task<List<USERS>> GetUserOccupation(int UserID);
    }
}
