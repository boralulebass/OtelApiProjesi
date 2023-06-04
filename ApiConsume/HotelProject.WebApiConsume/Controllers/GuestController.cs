using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _GuestService;

        public GuestController(IGuestService GuestService)
        {
            _GuestService = GuestService;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _GuestService.GetListT();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {
            _GuestService.InsertT(guest);
            return Ok();
        }
        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _GuestService.GetByIDT(id);
            _GuestService.DeleteT(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateGuest(Guest guest)
        {
            _GuestService.UpdateT(guest);
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetGuest(int id)
        {
            var values = _GuestService.GetByIDT(id);
            return Ok(values);
        }
    }
}
