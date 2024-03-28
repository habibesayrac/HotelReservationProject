using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _Dashboard2WidgetPartial : ViewComponent
	{
		public readonly IHttpClientFactory _httpClientFactory;

		public _Dashboard2WidgetPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:44362/api/Dashboard1Widgets/StaffCount");
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			ViewBag.staffCount = jsonData;


			var client2 = _httpClientFactory.CreateClient();
			var responseMessage2 = await client2.GetAsync("https://localhost:44362/api/Dashboard1Widgets/BookingCount");
			var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
			ViewBag.bookingCount = jsonData2;

			var client3 = _httpClientFactory.CreateClient();
			var responseMessage3 = await client3.GetAsync("https://localhost:44362/api/Dashboard1Widgets/AppUserCount");
			var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
			ViewBag.appUserCount = jsonData3;
			
			var client4 = _httpClientFactory.CreateClient();
			var responseMessage4 = await client4.GetAsync("https://localhost:44362/api/Dashboard1Widgets/RoomCount");
			var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
			ViewBag.roomCount = jsonData4;

			return View();
		}
	}
}