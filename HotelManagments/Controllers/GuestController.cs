using ApplicationManagment.ApplicationContext;
using ApplicationManagment.Services.Commands;
using ApplicationManagment.Services.Querys;
using EntityClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelManagments.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly GuestCommandService _guestCommandService;
        private readonly GuestQueryService _guestQueryService;

        public GuestController(GuestCommandService guestCommandService, GuestQueryService guestQueryService)
        {
            _guestCommandService = guestCommandService;
            _guestQueryService = guestQueryService;
        }

        // GET: api/Guest
        [HttpGet]
        public async Task<IActionResult> GetGuests()
        {
            var guests = await _guestQueryService.GetAllGuestsAsync();
            return Ok(guests);
        }

        // POST: api/Guest
        [HttpPost]
        public async Task<IActionResult> CreateGuest([FromBody] Guest guest)
        {
            if (guest == null)
            {
                return BadRequest();
            }
            await _guestCommandService.AddGuestAsync(guest);
            return CreatedAtAction(nameof(GetGuests), new { id = guest.Id }, guest);
        }
    }
}
