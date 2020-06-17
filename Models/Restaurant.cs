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
      var apiCallTask = ApiHelper.GetAll(EnvironmentVariables.ApiKey);
      var result = apiCallTask.Result;
      // JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      // var restaurantDictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonResponse.ToString());
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse["restaurants"].ToString());



    

  Console.WriteLine("\n\n\n");
  Console.WriteLine(restaurantList[0].Name);
  Console.WriteLine(restaurantList[0].ApiKey);
  Console.WriteLine("\n\n\n");



      return restaurantList;
    }

   


    public static Restaurant GetDetails(string ApiKey)
        {
          
            var apiCallTask = ApiHelper.GetDetails(ApiKey);
            var result = apiCallTask.Result;
            Console.WriteLine("\n\n\n");
            // Console.WriteLine(ApiKey);
            Console.WriteLine("\n\n\n");
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Restaurant restaurant = JsonConvert.DeserializeObject<Restaurant>(jsonResponse["restaurants"].ToString());

            return restaurant;
        }
  }
}
