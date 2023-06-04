using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _AboutService;

        public AboutController(IAboutService AboutService)
        {
            _AboutService = AboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _AboutService.GetListT();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(About About)
        {
            _AboutService.InsertT(About);
            return Ok();
        }
        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _AboutService.GetByIDT(id);
            _AboutService.DeleteT(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(About About)
        {
            _AboutService.UpdateT(About);
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _AboutService.GetByIDT(id);
            return Ok(values);
        }
    }
}
