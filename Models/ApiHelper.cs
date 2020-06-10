using System.Threading.Tasks;
using RestSharp;

namespace EarthlyRemediesClient.Models
{
    class ApiHelper
    {
        // Remedy API Helpers
        public static async Task<string> GetAllRemedies()
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"remedies", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> GetRemedy(int id)
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"remedies/{id}", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task Post(string newRemedy)
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"remedies", Method.POST);
            request.AddHeader("Content-Type", "applications/json");
            request.AddJsonBody(newRemedy);
            var response = await client.ExecuteTaskAsync(request);
        }

        public static async Task Put(int id, string updateRemedy)
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"remedies/{id}", Method.PUT);
            request.AddHeader("Content-Type", "applications/json");
            request.AddJsonBody(updateRemedy);  
            var response = await client.ExecuteTaskAsync(request); 
        }

        public static async Task Delete(int id)
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"remedies/{id}", Method.PUT);
            request.AddHeader("Content-Type", "applications/json");
            var response = await client.ExecuteTaskAsync(request); 
        }
    }
}