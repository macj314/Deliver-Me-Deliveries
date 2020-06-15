using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace deliver_me_deliveries.Models
{
  public class Restaurant
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public List<string> FoodTypes { get; set; }
    public string Phone { get; set; }
    public string Latitude { get; set; }
    public string longitude { get; set; }
    public string minFreeDelivery { get; set; }
    public string taxRate { get; set; }
    public string acceptsCash { get; set; }
    public string acceptsCard { get; set; }
    public bool offersPickup {get;set;}
    public bool offersDelivery {get;set;}
    public bool isTestRestaurant {get;set;}
    public int minWaitTime {get;set;}
    public int maxWaitTime {get;set;}
    public bool open {get;set;}
    public string url {get;set;}
    public int hours {get;set;}
    public int deliveryMin { get; set; }
    public string logoUrl { get; set; }

    public static Dictionary<string, object> GetRestaurants()
    {
      var apiCallTask = ApiHelper.GetAll(EnvironmentVariables.ApiKey);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      var restaurantList = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonResponse.ToString());
      // loop through restaurant key
      return restaurantList;
    }
  }
}




    // Models
// public static List<Restaurant> SearchRestaurants()
// {
//   var apiCallTask = ApiHelper.SearchRestaurants();
//   var result = apiCallTask.Result;
//   JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
//   List<Restautant> restaurantList = JsonConvert.DeserializeObject<List<Restautant>>(jsonResponse.ToString());
//   return restaurantList;
// }

// {
//             "apiKey": "364155d9f18155ceda325d7782b35bdb16a0039d4318f6d4",
//             "deliveryMin": 20.00,
// {
//             "apiKey": "364155d9f18155ceda325d7782b35bdb16a0039d4318f6d4",
//             "deliveryMin": 20.00,
//             "logoUrl": "https://static.eatstreet.com/assets/images/restaurant_logos/alberonas-pizza-and-pasta-7118_1419612317109.png",
//             "name": "Alberona's Pizza & Pasta",
//             "streetAddress": "3624 Leary Way NW",
//             "city": "Seattle",
//             "state": "WA",
//             "zip": "98107",
//             "foodTypes": [
//                 "Subs & Sandwiches",
//                 "Pasta",
//                 "Pizza",
//                 "Italian Food",
//                 "Healthy Food",
//                 "Greek Food",
//                 "Italian"
//             ],
//             "phone": "(206) 547-9404",
//             "latitude": 47.654014,
//             "longitude": -122.359649,
//             "minFreeDelivery": -1.0000,
//             "taxRate": 0.0950,
//             "acceptsCash": true,
//             "acceptsCard": true,
//             "offersPickup": true,
//             "offersDelivery": true,
//             "isTestRestaurant": false,
//             "minWaitTime": 45,
//             "maxWaitTime": 60,
//             "open": false,
//             "url": "https://eatstreet.com/seattle-wa/restaurants/alberonas-pizza-and-pasta",
//             "hours": {
//                 "Monday": [
//                     "4:00 PM - 1:00 AM"
//                 ],
//                 "Saturday": [
//                     "4:00 PM - 1:00 AM"
//                 ],
//                 "Sunday": [
//                     "4:00 PM - 1:00 AM"
//                 ],
//                 "Wednesday": [
//                     "4:00 PM - 1:00 AM"
//                 ],
//                 "Tuesday": [
//                     "4:00 PM - 1:00 AM"
//                 ],
//                 "Friday": [
//                     "4:00 PM - 1:00 AM"
//                 ],
//                 "Thursday": [
//                     "4:00 PM - 1:00 AM"
//                 ]
//             },
//             "timezone": "US/Pacific"
//         },