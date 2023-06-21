using HotelProject.WebUI.Dtos.Followers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ResultInstagramFollowersDto resultInstagramFollowersDtos = new ResultInstagramFollowersDto();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/boralulebas"),
                Headers =
    {
        { "X-RapidAPI-Key", "15aa1de390msh0f972a9da373526p19358bjsn0df8be2dbcaf" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1 = resultInstagramFollowersDtos.followers;
                ViewBag.v2 = resultInstagramFollowersDtos.following;
            }

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=mozbi43"),
                Headers =
    {
        { "X-RapidAPI-Key", "15aa1de390msh0f972a9da373526p19358bjsn0df8be2dbcaf" },
        { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.v3 = resultTwitterFollowersDto.data.user_info.followers_count;
                ViewBag.v4 = resultTwitterFollowersDto.data.user_info.friends_count;
            }

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://linkedin-profiles1.p.rapidapi.com/extract?url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fboralulebas4%2F&html=1"),
                Headers =
    {
        { "X-RapidAPI-Key", "15aa1de390msh0f972a9da373526p19358bjsn0df8be2dbcaf" },
        { "X-RapidAPI-Host", "linkedin-profiles1.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLinkedInFollowersDto resultLinkedInFollowersDto = JsonConvert.DeserializeObject<ResultLinkedInFollowersDto>(body3);
                ViewBag.v5 = resultLinkedInFollowersDto.extractor.interactionStatistic.userInteractionCount.ToString();
            }
            return View();

        }
    }
}
