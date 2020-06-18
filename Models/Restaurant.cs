using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection;


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
    public string LogoUrl {get;set;}
    public string ApiKey {get;set;}


    // public string minFreeDelivery { get; set; }
    // public bool offersPickup { get; set; }
    // public bool offersDelivery { get; set; }
    // public bool open { get; set; }
    // public string url { get; set; }
    // public string hours { get; set; }
    // public string deliveryMin { get; set; }
    // public string logoUrl { get; set; }

    public static List<Restaurant> GetRestaurants()
    {
      var apiCallTask = ApiHelper.GetAll(EnvironmentVariables.apiKey);
      var result = apiCallTask.Result;
      // JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      // var restaurantDictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonResponse.ToString());
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse["restaurants"].ToString());
//     foreach (var item in restaurantList)
// {
// Console.WriteLine(item.Name);
// }


//       Console.WriteLine( restaurantList );
      // Console.WriteLine("\n\n Restaurant Name: {0} ApiKey {1}", restaurantList[1].Name, restaurantList[1].ApiKey + "\n\n");
      // Console.WriteLine("\n\n Restaurant Name: {0} ApiKey {1}", restaurantList[2].Name, restaurantList[2].ApiKey + "\n\n");



      return restaurantList;
    }
      //returns us an object deliver_me_deliveries.Models.Restaurant
    public static Restaurant GetDetail(string ApiKey)
        {
          
            var apiCallTask = ApiHelper.GetDetails(ApiKey);
            var result = apiCallTask.Result;
      
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Restaurant restaurant = JsonConvert.DeserializeObject<Restaurant>(jsonResponse.ToString());


            // Console.WriteLine("\n\n" + restaurant + "\n\n");
            
            Console.WriteLine("\n\n" + result + "\n\n");
          
            

            return restaurant;
        }
  }
}
