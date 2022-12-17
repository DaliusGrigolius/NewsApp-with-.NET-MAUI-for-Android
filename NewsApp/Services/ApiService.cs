using NewsApp.Models;
using Newtonsoft.Json;

namespace NewsApp.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews(string categoryName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=YOUR_TOKEN_HERE&topic=breaking-news&lang=en&topic=" + categoryName.ToLower());

            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
