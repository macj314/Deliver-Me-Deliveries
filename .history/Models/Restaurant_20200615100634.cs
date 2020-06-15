using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace deliver_me_deliveries.Models
{
  public class Restaurant
  {
    public string Name { get; }
    public string StreetAddress { get; }
    public string City { get; }
    public string State { get; }
    public string Zip { get; }
    public List<string> FoodTypes { get; }
    public string Phone { get; }
  }
}


    // Models
    // public static List<Restaurant> SearchRestaurants()
    // {
    //   var apiCallTask = ApiHelper.SearchRestaurants();
    //   var result = apiCallTask.Result;
    //   JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    //   List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(jsonResponse.ToString());
    //   return bookList;
    // }

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