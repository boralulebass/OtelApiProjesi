using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		private readonly IRoomService _RoomService;

		public RoomController(IRoomService RoomService)
		{
			_RoomService = RoomService;
		}

		[HttpGet]
		public IActionResult RoomList()
		{
			var values = _RoomService.GetListT();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddRoom(Room Room)
		{
			_RoomService.InsertT(Room);
			return Ok();
		}
		[HttpDelete("[action]/{id}")]
		public IActionResult DeleteRoom(int id)
		{
			var values = _RoomService.GetByIDT(id);
			_RoomService.DeleteT(values);
			return Ok();
		}
		[HttpPut]

        public IActionResult UpdateRoom(Room Room)
		{
			_RoomService.UpdateT(Room);
			return Ok();
		}
		[HttpGet("[action]/{id}")]
		public IActionResult GetRoom(int id)
		{
			var values = _RoomService.GetByIDT(id);
			return Ok(values);
		}
	}
}
