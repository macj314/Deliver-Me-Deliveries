using System.Threading.Tasks;
using RestSharp;
using System;

namespace deliver_me_deliveries.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll(string apiKey)
    {
      RestClient client = new RestClient("https://eatstreet.com/publicapi/v1");
      RestRequest request = new RestRequest($"restaurant/search?method=both&street-address=316+W.+Washington+Ave.+Madison+WI", Method.GET);
      request.AddHeader("X-Access-Token", apiKey);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Search(string searchTerm)
    {
      //set api call variables
      RestClient baseRequest = new RestClient("https://eatstreet.com/publicapi/v1/search");
      RestRequest request = new RestRequest($"?street-address={searchTerm}", Method.GET);
      request.AddHeader("X-Access-Token", EnvironmentVariables.ApiKey);
      var response = await baseRequest.ExecuteTaskAsync(request);

      //print url to console
      Uri fullUrl = response.ResponseUri;
      Console.WriteLine(string.Format("response URI: {0}", response.ResponseUri.ToString()));


      return response.Content;
    }
  }
}