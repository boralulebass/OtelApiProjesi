using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _BookingService;

        public BookingController(IBookingService BookingService)
        {
            _BookingService = BookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _BookingService.GetListT();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking Booking)
        {
            _BookingService.InsertT(Booking);
            return Ok();
        }
        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _BookingService.GetByIDT(id);
            _BookingService.DeleteT(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking Booking)
        {
            _BookingService.UpdateT(Booking);
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult UpdateReservationStatus(int id)
        {
            _BookingService.TBookingStatusChange(id);
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _BookingService.GetByIDT(id);
            return Ok(values);
        }
        [HttpGet("[action]")]
        public IActionResult Last6Booking()
        {
            var values = _BookingService.Last6Bookings();
            return Ok(values);
        }
    }
}
