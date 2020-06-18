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

    public static async Task<string> GetDetails() //pass through id as well
    {    
      string ApiKey = "364155d9f18155ce884225aec137a02a852e59e584ee9c4a";
      RestClient baseUrl = new RestClient("https://eatstreet.com/publicapi/v1");
      RestRequest request = new RestRequest($"restaurant/{ApiKey}", Method.GET);
      request.AddHeader("X-Access-Token", EnvironmentVariables.ApiKey);
      // var response = await client.ExecuteTaskAsync(request);
          
      var response = await baseUrl.ExecuteTaskAsync(request);
      Uri fullUrl = response.ResponseUri;

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
      Uri fullUrl = response.ResponseUri;

      return response.Content;
    }
  }
}