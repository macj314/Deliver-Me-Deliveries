using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace deliver_me_deliveries.Models
{
  public class Restaurant
  {
    public int Id { get; set; }
    public string Name { get;set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public List<string> FoodTypes { get; set; }
    public string Phone { get; set; }
    public string minFreeDelivery { get; set; }
    public bool offersPickup { get; set; }
    public bool offersDelivery { get; set; }
    public bool open { get; set; }
    public string url { get; set; }
    public int hours { get; set; }
    public int deliveryMin { get; set; }
    public string logoUrl { get; set; }

    public static Dictionary<string, object> GetRestaurants()
    {
      var apiCallTask = ApiHelper.GetAll(EnvironmentVariables.ApiKey);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      var restaurantDictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonResponse.ToString());
      List<Restaurant> restaurantList = new List<Restaurant>();
      // foreach through restaurants "restaurants = Array of...
      // assign values to Restaurant Model Properties
      // When all properties for one restaurant are assigned: add Restaurant to list<Restaurant>
      // Return list<Restaurant> 
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.WriteLine(restaurantDictionary["restaurants.name"]);
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      foreach(KeyValuePair<string,object> entry in restaurantDictionary)
      {        
        if (entry.Key == "restaurants")
        {
          // restaurant.Name = "name";
        }
      }
      return restaurantDictionary;
    }
        // "address": {
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
  }
}