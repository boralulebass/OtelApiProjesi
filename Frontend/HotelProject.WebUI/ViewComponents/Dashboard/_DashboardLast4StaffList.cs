using HotelProject.WebUI.Dtos.Guest;
using HotelProject.WebUI.Dtos.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardLast4StaffList :ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public _DashboardLast4StaffList(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task< IViewComponentResult> InvokeAsync()
		{
			var vlient = _httpClientFactory.CreateClient();
			var responseMessage = await vlient.GetAsync("https://localhost:7232/api/Staff/Last4Staff");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultLast4StaffDto>>(jsonData);

				return View(values);
			}
			return View();
		}
	}
}
