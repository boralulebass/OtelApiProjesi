using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _WorkLocationService;

        public WorkLocationController(IWorkLocationService WorkLocationService)
        {
            _WorkLocationService = WorkLocationService;
        }

        [HttpGet]
        public IActionResult WorkLocationList()
        {
            var values = _WorkLocationService.GetListT();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddWorkLocation(WorkLocation WorkLocation)
        {
            _WorkLocationService.InsertT(WorkLocation);
            return Ok();
        }
        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteWorkLocation(int id)
        {
            var values = _WorkLocationService.GetByIDT(id);
            _WorkLocationService.DeleteT(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateWorkLocation(WorkLocation WorkLocation)
        {
            _WorkLocationService.UpdateT(WorkLocation);
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetWorkLocation(int id)
        {
            var values = _WorkLocationService.GetByIDT(id);
            return Ok(values);
        }
    }
}
