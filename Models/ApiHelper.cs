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
      public static async Task<string> GetPage(string apiKey, string page)
    {
      Console.WriteLine($"Page: {page} <========================");
      RestClient client = new RestClient("https://eatstreet.com/publicapi/v1");
      RestRequest request = new RestRequest($"restaurant/search?method=both&street-address=316+W.+Washington+Ave.+Madison+WI?page={page}", Method.GET);
      request.AddHeader("X-Access-Token", apiKey);
      var response = await client.ExecuteTaskAsync(request);
      
      return response.Content;
    }
     
  }
}

    //     "latitude": 43.0728649,
    //     "longitude": -89.38809499999999,
    //     "city": "Madison",
    //     "state": "WI",
    //     "zip": "53703",
    //     "aptNumber": null
    // },
    // "restaurants": [
    //     {
    //         "apiKey": "364155d9f18155ceda325d7782b35bdb9696f108a9a450c0",
    //         "deliveryMin": 0.00,
    //         "deliveryPrice": 2.99,
    //         "logoUrl": "https://static.eatstreet.com/assets/images/restaurant_logos/107-state-71386_1578050374619.png",
    //         "name": "107 State",
    //         "streetAddress": "107 State St",
    //         "city": "Madison",
    //         "state": "WI",
    //         "zip": "53703",
    //         "foodTypes": [
    //             "Pasta",
    //             "Sandwiches",
    //             "Burgers",
    //             "American (Traditional)",
    //             "Italian"
    //         ],
    //         "phone": "(608) 630-8184",
    //         "latitude": 43.0746358,
    //         "longitude": -89.3870334,
    //         "minFreeDelivery": 0.00,
    //         "taxRate": 0.0550,
    //         "acceptsCash": false,
    //         "acceptsCard": true,
    //         "offersPickup": true,
    //         "offersDelivery": true,
    //         "isTestRestaurant": false,
    //         "minWaitTime": 45,
    //         "maxWaitTime": 60,
    //         "open": false,
    //         "url": "https://eatstreet.com/madison-wi/restaurants/capital-tap-haus-107-state-st",
    //         "hours": {
    //             "Saturday": [
    //                 "5:00 PM - 8:00 PM"
    //             ],
    //             "Wednesday": [
    //                 "5:00 PM - 8:00 PM"
    //             ],
    //             "Tuesday": [
    //                 "5:00 PM - 8:00 PM"
    //             ],
    //             "Friday": [
    //                 "5:00 PM - 8:00 PM"
    //             ],
    //             "Thursday": [
    //                 "5:00 PM - 8:00 PM"
    //             ]
    //         },
    //         "timezone": "US/Central"
    //     },
    //     "apiKey": null,
    //     "streetAddress": "316 West Washington Avenue",
    //     "latitude": 43.0728649,
    //     "longitude": -89.38809499999999,
    //     "city": "Madison",
    //     "state": "WI",
    //     "zip": "53703",
    //     "aptNumber": null
    // },
    // "restaurants": [
    //     {
    //         "apiKey": "364155d9f18155ceda325d7782b35bdb9696f108a9a450c0",
    //         "deliveryMin": 0.00,
    //         "deliveryPrice": 2.99,
    //         "logoUrl": "https://static.eatstreet.com/assets/images/restaurant_logos/107-state-71386_1578050374619.png",
    //         "name": "107 State",
    //         "streetAddress": "107 State St",
    //         "city": "Madison",
    //         "state": "WI",
    //         "zip": "53703",
    //         "foodTypes": [
    //             "Pasta",
    //             "Sandwiches",
    //             "Burgers",
    //             "American (Traditional)",
    //             "Italian"
    //         ],
    //         "phone": "(608) 630-8184",
    //         "latitude": 43.0746358,
    //         "longitude": -89.3870334,
    //         "minFreeDelivery": 0.00,
    //         "taxRate": 0.0550,
    //         "acceptsCash": false,
    //         "acceptsCard": true,
    //         "offersPickup": true,
    //         "offersDelivery": true,
    //         "isTestRestaurant": false,
    //         "minWaitTime": 45,
    //         "maxWaitTime": 60,
    //         "open": false,
    //         "url": "https://eatstreet.com/madison-wi/restaurants/capital-tap-haus-107-state-st",
    //         "hours": {
    //             "Saturday": [
    //                 "5:00 PM - 8:00 PM"
    //             ],
    //             "Wednesday": [
    //                 "5:00 PM - 8:00 PM"
    //             ],
    //             "Tuesday": [
    //                 "5:00 PM - 8:00 PM"
    //             ],
    //             "Friday": [
    //                 "5:00 PM - 8:00 PM"
    //             ],
    //             "Thursday": [
    //                 "5:00 PM - 8:00 PM"
    //             ]
    //         },
    //         "timezone": "US/Central"
    //     },

    //  public static async Task<string> GetPage(string page)
    // {
    //   Console.WriteLine($"Page: {page} <========================");
    //   RestClient client = new RestClient("http://localhost:5006/api");
    //   RestRequest request = new RestRequest($"books?page={page}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
      
    //   return response.Content;
    // }


    // public static async Task<string> Get(int id)
    // {
    //   RestClient client = new RestClient("http://localhost:5006/api");
    //   RestRequest request = new RestRequest($"books/{id}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

// P5LG4JN6VERBYZJRTPHAMLF75I======