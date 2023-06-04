using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _MessageCategoryService;

        public MessageCategoryController(IMessageCategoryService MessageCategoryService)
        {
            _MessageCategoryService = MessageCategoryService;
        }

        [HttpGet]
        public IActionResult MessageCategoryList()
        {
            var values = _MessageCategoryService.GetListT();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMessageCategory(MessageCategory2 MessageCategory)
        {
            _MessageCategoryService.InsertT(MessageCategory);
            return Ok();
        }
        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteMessageCategory(int id)
        {
            var values = _MessageCategoryService.GetByIDT(id);
            _MessageCategoryService.DeleteT(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMessageCategory(MessageCategory2 MessageCategory)
        {
            _MessageCategoryService.UpdateT(MessageCategory);
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetMessageCategory(int id)
        {
            var values = _MessageCategoryService.GetByIDT(id);
            return Ok(values);
        }
    }
}
