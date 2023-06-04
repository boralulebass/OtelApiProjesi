using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace HotelProject.WebUI.Controllers
{
    public class AdminImageFileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile file)
        {
            var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            var bytes = stream.ToArray();

            ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);
            byteArrayContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(file.ContentType);
            MultipartFormDataContent multip = new MultipartFormDataContent();
            multip.Add(byteArrayContent, "file", file.FileName);
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.PostAsync("https://localhost:7232/api/FileImage", multip);
            if(responseMessage.IsSuccessStatusCode)
            {
                return View();
            }
            return View();
        }
    }
}
