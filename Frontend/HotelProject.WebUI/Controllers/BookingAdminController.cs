using HotelProject.WebUI.Dtos.Booking;
using HotelProject.WebUI.Dtos.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var vlient = _httpClientFactory.CreateClient();
            var responseMessage = await vlient.GetAsync("https://localhost:7232/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> ApprovedReservation(int id)
        {
            //var client = _httpClientFactory.CreateClient();
            //var responseMessage = await client.PutAsync("https://localhost:7232/api/Booking/UpdateReservationStatus?id="+ id);
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    return RedirectToAction("Index");
            //}
            return RedirectToAction("Index");
        }
    }
}
