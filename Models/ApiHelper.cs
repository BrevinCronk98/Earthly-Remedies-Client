using System.Threading.Tasks;
using RestSharp;

namespace EarthlyRemediesClient.Models
{
    class ApiHelper
    {
        public static async Task<string> GetAllRemedies()
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"remedies", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
    }
}