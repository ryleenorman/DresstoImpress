
//By Emily Mago

using DresstoImpressAPI.Repositories;
using DresstoImpressAPI2.Entities;
using DresstoImpressAPI2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DresstoImpressAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutfitController : Controller
    {
        private readonly IOutfitService outfit_EM;
        public OutfitController(IOutfitService Outfit_EM)
        {
            this.outfit_EM = Outfit_EM;
        }
        [HttpGet("{outfitid}")]
        public async Task<List<Outfit>> GetOutfitDetails(int outfitid)
        {
            var outfitDetails = await outfit_EM.GetOutfitDetails(outfitid);
            /* if (outfitid == null)
             {
                 return NotFound()
             }*/
            return outfitDetails;
        }
    }
}

