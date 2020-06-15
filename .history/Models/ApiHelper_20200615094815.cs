using System.Threading.Tasks;
using RestSharp;
using System;

namespace deliver_me_deliveries.Models
{
  class ApiHelper
  {

    //   static void Main()
    // {
    //   var apiCallTask = ApiHelper.ApiCall("P5LG4JN6VERBYZJRTPHAMLF75I======");
    //   var result = apiCallTask.Result;
    //   Console.WriteLine(result);
    // }


    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://eatstreet.com/publicapi/v1/restaurant");
      RestRequest request = new RestRequest($"home.json?api-key={EnviromentalVariables.apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}

// P5LG4JN6VERBYZJRTPHAMLF75I======