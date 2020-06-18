using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection;
using System.Diagnostics;

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
    public string ApiKey { get; set; }
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

    public static Restaurant GetDetails(string ApiKey)
    {        
      var apiCallTask = ApiHelper.GetDetails();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Restaurant restaurant = JsonConvert.DeserializeObject<Restaurant>(jsonResponse["restaurants"].ToString());
      return restaurant;
    }

    public static List<Restaurant> Search(string addressSearch, string method, string extraTerm = "")
    {
      
      var apiCallTask = ApiHelper.Search(addressSearch, method, extraTerm);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse["restaurants"].ToString());
      return restaurantList;
    }
  }
}
