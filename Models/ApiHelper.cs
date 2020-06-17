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
      System.Console.WriteLine(response.Content);
      return response.Content;
    }
     public static async Task<string> GetDetails(string ApiKey) //pass through id as well
        {
          
            RestClient baseUrl = new RestClient("https://eatstreet.com/publicapi/v1");
            RestRequest request = new RestRequest($"restaurant/{ApiKey}", Method.GET);
            request.AddHeader("X-Access-Token", EnvironmentVariables.AuthKey);
            // var response = await client.ExecuteTaskAsync(request);
        

      var response = await baseUrl.ExecuteTaskAsync(request);
      Uri fullUrl = response.ResponseUri;
      Console.WriteLine(string.Format("\n\n response URI: {0}", response.ResponseUri.ToString() + "\n\n")); //print url to console for testing

            return response.Content;
        }
    
    public static async Task<string> Search(string addressSearch, string extraTerm = "", string method = "both")
    {
      //set up RestSharp api variables
      RestClient baseUrl = new RestClient("https://eatstreet.com/publicapi/v1/");
      RestRequest request = new RestRequest($"restaurant/search?", Method.GET);

      //additional parameters to add to the request
      request.AddHeader("X-Access-Token", EnvironmentVariables.ApiKey); //authentication
      if(extraTerm != ""){ request.AddQueryParameter("search", extraTerm); }  //extra search term
      request.AddQueryParameter("method", method); //delivery/pickup/both
      request.AddQueryParameter("street-address", addressSearch); //street address
    
       var response = await baseUrl.ExecuteTaskAsync(request);
       Uri fullUrl = response.ResponseUri;
      Console.WriteLine(string.Format("\n\n response URI: {0}", response.ResponseUri.ToString() + "\n\n")); //print url to console for testing

      return response.Content;
    }
  }
}

