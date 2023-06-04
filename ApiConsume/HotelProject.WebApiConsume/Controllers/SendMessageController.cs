using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _SendMessageService;

        public SendMessageController(ISendMessageService SendMessageService)
        {
            _SendMessageService = SendMessageService;
        }
        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _SendMessageService.GetListT();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSendMessage(SendMessage SendMessage)
        {
            _SendMessageService.InsertT(SendMessage);
            return Ok();
        }
        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var values = _SendMessageService.GetByIDT(id);
            _SendMessageService.DeleteT(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage SendMessage)
        {
            _SendMessageService.UpdateT(SendMessage);
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _SendMessageService.GetByIDT(id);
            return Ok(values);
        }
        [HttpGet("[action]")]
        public IActionResult SendMessageCount()
        {
            var values = _SendMessageService.TSendMessageCount();
            return Ok(values);
        }
    }
}
