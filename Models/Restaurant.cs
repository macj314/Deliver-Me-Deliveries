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
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse["restaurants"].ToString());
      return restaurantList;
    }

    public static List<Restaurant> Search(string addressSearch, string extraTerm = "", string method = "both")
    {
      var apiCallTask = ApiHelper.Search(addressSearch, extraTerm, method);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse["restaurants"].ToString());
      return restaurantList;
    }
  }
}
