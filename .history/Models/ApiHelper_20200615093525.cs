using System.Threading.Tasks;
using RestSharp;
using System.Threading.Tasks;

namespace DeliverMeDeliveries.Models
{
  class ApiHelper
  {

      static void Main()
    {
      var apiCallTask = ApiHelper.ApiCall("[YOUR-API-KEY-HERE]");
      var result = apiCallTask.Result;
      Console.WriteLine(result);
    }
    public static async Task<string> GetAll(string apiKey)
    {
      RestClient client = new RestClient("https://eatstreet.com/publicapi/v1/restaurant");
      RestRequest request = new RestRequest($"home", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}