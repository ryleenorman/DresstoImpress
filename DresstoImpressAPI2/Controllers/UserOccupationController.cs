// Emily Surface
using DresstoImpressAPI2.Entities;
using DresstoImpressAPI2.Entities;
using DresstoImpressAPI2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DresstoImpressAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOccupationController : ControllerBase
    {
        private readonly IUserOccupationService _userOccupation;

        public UserOccupationController(IUserOccupationService userOccupation)
        {
            _userOccupation = userOccupation;
        }

        [HttpGet("{UserId}")]
        public async Task<ActionResult<List<USERS>>> GetUserOccupation(int UserId)
        {
            var userOccupation = await _userOccupation.GetUserOccupation(UserId);
            if (userOccupation == null)
            {
                return NotFound();
            }
            return userOccupation;
        }
    }
}