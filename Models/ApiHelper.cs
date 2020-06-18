using System.Threading.Tasks;
using RestSharp;

namespace deliver_me_deliveries.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll(string apiKey)
    {
      RestClient client = new RestClient("https://eatstreet.com/publicapi/v1");
      RestRequest request = new RestRequest($"restaurant/search?method=delivery&street-address=Seattle", Method.GET);
      request.AddHeader("X-Access-Token", apiKey);

      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
        
    public static async Task<string> Search(string addressSearch, string extraTerm = "")
    {
      //set up RestSharp api variables
      RestClient baseUrl = new RestClient("https://eatstreet.com/publicapi/v1/");
      RestRequest request = new RestRequest($"restaurant/search?", Method.GET);

      //additional parameters to add to the request
      request.AddHeader("X-Access-Token", EnvironmentVariables.ApiKey); //authentication
      if(extraTerm != ""){ request.AddQueryParameter("search", extraTerm); }  //extra search term
      request.AddQueryParameter("method", "delivery"); //delivery/pickup/both
      request.AddQueryParameter("street-address", addressSearch); //street address
    
      var response = await baseUrl.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetDetails(string apiKey)
    {
        RestClient client = new RestClient("https://eatstreet.com/publicapi/v1/");
        RestRequest request = new RestRequest($"restaurant/{apiKey}", Method.GET);
        request.AddHeader("X-Access-Token", EnvironmentVariables.ApiKey);

        var response = await client.ExecuteTaskAsync(request);
        return response.Content;
    }
  }
}