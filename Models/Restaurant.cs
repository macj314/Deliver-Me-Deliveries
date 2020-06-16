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
    public string minFreeDelivery { get; set; }
    public bool offersPickup { get; set; }
    public bool offersDelivery { get; set; }
    public bool open { get; set; }
    public string url { get; set; }
    public string hours { get; set; }
    public string deliveryMin { get; set; }
    public string logoUrl { get; set; }

    public static Dictionary<string, object> GetRestaurants()
    {
      var apiCallTask = ApiHelper.GetAll(EnvironmentVariables.ApiKey);
      var result = apiCallTask.Result;
      // JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      // var restaurantDictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonResponse.ToString());
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse["restaurants"].ToString());

      foreach (Restaurant restaurant in restaurantList)
      {
        Console.WriteLine($"Section: {restaurant.Name}");
        Console.WriteLine($"Title: {restaurant.City}");
        Console.WriteLine($"Abstract: {restaurant.State}");
        Console.WriteLine($"Url: {restaurant.Zip}");
      }
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      // List<Restaurant> restaurantList = new List<Restaurant>();     
      // restaurantDictionary["restaurants"] = new Restaurant();
      Dictionary<string, object> x = new Dictionary<string, object>();
      return x;
    }
    // List<Restaurant> restaurantList = new List<Restaurant>();
    // foreach through restaurants "restaurants = Array of...
    // assign values to Restaurant Model Properties
    // When all properties for one restaurant are assigned: add Restaurant to list<Restaurant>
    // Return list<Restaurant> 
  }
}
