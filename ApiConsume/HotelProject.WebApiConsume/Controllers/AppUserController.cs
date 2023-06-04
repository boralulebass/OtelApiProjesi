using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService AppUserService)
        {
            _appUserService = AppUserService;
        }
        [HttpGet]
        public IActionResult AppUserList()
        {
            var values = _appUserService.GetListT();
            return Ok(values);
        }
    }
}
