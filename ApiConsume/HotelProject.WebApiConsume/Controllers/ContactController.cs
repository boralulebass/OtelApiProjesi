using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _ContactService;

        public ContactController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _ContactService.GetListT();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddContact(Contact Contact)
        {
            Contact.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _ContactService.InsertT(Contact);
            return Ok();
        }
        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _ContactService.GetByIDT(id);
            _ContactService.DeleteT(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateContact(Contact Contact)
        {
            _ContactService.UpdateT(Contact);
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetContact(int id)
        {
            var values = _ContactService.GetByIDT(id);
            return Ok(values);
        }
        [HttpGet("[action]")]
        public IActionResult GetContactCount()
        {
            var values = _ContactService.TGetContactCount();
            return Ok(values);
        }
    }
}
