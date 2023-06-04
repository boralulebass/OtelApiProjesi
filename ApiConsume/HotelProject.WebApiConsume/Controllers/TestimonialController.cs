using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _TestimonialService;

		public TestimonialController(ITestimonialService TestimonialService)
		{
			_TestimonialService = TestimonialService;
		}

		[HttpGet]
		public IActionResult TestimonialList()
		{
			var values = _TestimonialService.GetListT();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddTestimonial(Testimonial Testimonial)
		{
			_TestimonialService.InsertT(Testimonial);
			return Ok();
		}
		[HttpDelete("[action]/{id}")]
		public IActionResult DeleteTestimonial(int id)
		{
			var values = _TestimonialService.GetByIDT(id);
			_TestimonialService.DeleteT(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateTestimonial(Testimonial Testimonial)
		{
			_TestimonialService.UpdateT(Testimonial);
			return Ok();
		}
		[HttpGet("[action]/{id}")]
		public IActionResult GetTestimonial(int id)
		{
			var values = _TestimonialService.GetByIDT(id);
			return Ok(values);
		}
	}
}
