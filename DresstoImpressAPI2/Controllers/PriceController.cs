//By Emily Mago

using DresstoImpressAPI2.Entities;
using DresstoImpressAPI2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DresstoImpressAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : Controller
    {
        private readonly IPriceService price_em;
        public PriceController(IPriceService Price_EM)
        {
            this.price_em = Price_EM;
        }
        [HttpGet("{clothingid}")]
        public async Task<List<Clothing>> GetPriceDetails(int clothingid)
        {
            var PriceDetails = await price_em.GetPriceDetails(clothingid);

            return PriceDetails;
        }
    }
}