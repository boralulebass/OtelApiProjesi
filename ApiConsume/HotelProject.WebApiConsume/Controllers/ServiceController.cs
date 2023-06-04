using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		private readonly IServiceService _ServiceService;

		public ServiceController(IServiceService ServiceService)
		{
			_ServiceService = ServiceService;
		}

		[HttpGet]
		public IActionResult ServiceList()
		{
			var values = _ServiceService.GetListT();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddService(Service Service)
		{
			_ServiceService.InsertT(Service);
			return Ok();
		}
		[HttpDelete("[action]/{id}")]
		public IActionResult DeleteService(int id)
		{
			var values = _ServiceService.GetByIDT(id);
			_ServiceService.DeleteT(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateService(Service Service)
		{
			_ServiceService.UpdateT(Service);
			return Ok();
		}
		[HttpGet("[action]/{id}")]
		public IActionResult GetService(int id)
		{
			var values = _ServiceService.GetByIDT(id);
			return Ok(values);
		}
	}
}
