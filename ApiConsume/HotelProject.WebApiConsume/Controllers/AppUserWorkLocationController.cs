using HotelProject.DataAccessLayer.Concrete;
using HotelProject.WebApiConsume.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWorkLocationController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetListWWL()
        {
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWorkLocationViewModel
            {
                Name = y.Name,
                Surname = y.Surname,
                WorkLocationID = y.WorkLocationID,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                City = y.City,
                Country = y.Country,
                Gender = y.Gender,
                ImageUrl = y.ImageUrl
            }).ToList();
            return Ok(values);
        }
    }
}
