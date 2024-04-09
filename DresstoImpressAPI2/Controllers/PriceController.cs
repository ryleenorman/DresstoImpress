//By Emily Mago

using DresstoImpressAPI2.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DresstoImpressAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : Controller
    {
        private readonly IPriceService priceService;

        public PriceController(IPriceService PriceService)
        {
            this.priceService = PriceService;
        }

        [HttpGet("{clothingId}")]
        public async Task<ActionResult<decimal?>> GetPriceDetails(int clothingId)
        {
            var price = await priceService.GetPriceDetails(clothingId);

            if (price == null)
            {
                return NotFound();
            }

            return Ok(price);
        }
    }
}
