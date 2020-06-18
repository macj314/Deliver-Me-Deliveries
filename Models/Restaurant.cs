using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

    public static List<Restaurant> GetRestaurants()
    {
      var apiCallTask = ApiHelper.GetAll(EnvironmentVariables.ApiKey);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse["restaurants"].ToString());
      return restaurantList;
    }

    public static List<Restaurant> Search(string addressSearch, string extraTerm = "")
    {     
      var apiCallTask = ApiHelper.Search(addressSearch, extraTerm);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse["restaurants"].ToString());
      return restaurantList;
    }

    public static Restaurant GetDetail(string ApiKey)
    {     
      var apiCallTask = ApiHelper.GetDetails(ApiKey);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Restaurant restaurant = JsonConvert.DeserializeObject<Restaurant>(jsonResponse["restaurant"].ToString());
      return restaurant;
    }
  }
}
