using HotelProject.WebUI.Dtos.About;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace HotelProject.WebUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
