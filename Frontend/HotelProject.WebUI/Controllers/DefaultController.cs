using HotelProject.WebUI.Dtos.Service;
using HotelProject.WebUI.Dtos.Subscribe;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]

    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult _SubscribePartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _SubscribePartial(CreateSubsDto subsDto)
        { 
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(subsDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var respMessage = await client.PostAsync("https://localhost:7232/api/Subscribe",content);
            if (respMessage.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
