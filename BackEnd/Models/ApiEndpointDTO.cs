using System.Collections.Generic;
using FrontEndRequests;
using Newtonsoft.Json;

namespace BackEnd.Models
{
  public partial class ApiEndpoint
  {
    [JsonProperty("endpoints")]
    public List<Endpoint> Endpoints { get; set; }
  }

  public partial class Endpoint
  {
    [JsonProperty("/api", NullValueHandling = NullValueHandling.Ignore)]
    public Api Api { get; set; }

    [JsonProperty("/api/login", NullValueHandling = NullValueHandling.Ignore)]
    public ApiLogin ApiLogin { get; set; }

    [JsonProperty("/api/user/:id", NullValueHandling = NullValueHandling.Ignore)]
    public ApiUserId ApiUserId { get; set; }

    [JsonProperty("/api/garage/:id", NullValueHandling = NullValueHandling.Ignore)]
    public ApiGarageId ApiGarageId { get; set; }

    [JsonProperty("/api/location/distance", NullValueHandling = NullValueHandling.Ignore)]
    public ApiLocationDistance ApiLocationDistance { get; set; }

    [JsonProperty("/api/registration", NullValueHandling = NullValueHandling.Ignore)]
    public ApiRegistration ApiRegistration { get; set; }
  }

  public partial class Api
  {
    [JsonProperty("GET:")]
    public ApiGet Get { get; set; }
  }

  public partial class ApiGet
  {
    [JsonProperty("description")]
    public string Description { get; set; }
  }

  public partial class ApiGarageId
  {
    [JsonProperty("GET:")]
    public ApiGarageIdGet Get { get; set; }
  }

  public partial class ApiGarageIdGet
  {
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("queries")]
    public List<object> Queries { get; set; }

    [JsonProperty("exampleResponse")]
    public GarageDTO ExampleResponse { get; set; }
  }

  public partial class ApiLocationDistance
  {
    [JsonProperty("GET:")]
    public ApiLocationDistanceGet Get { get; set; }
  }

  public partial class ApiLocationDistanceGet
  {
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("queries")]
    public List<string> Queries { get; set; }

    [JsonProperty("exampleRequestURL")]
    public string ExampleRequestUrl { get; set; }

    [JsonProperty("exampleResponse")]
    public List<GarageDistanceDTO> ExampleResponse { get; set; }
  }

  public partial class ApiLogin
  {
    [JsonProperty("POST:")]
    public Post Post { get; set; }
  }

  public partial class ApiRegistration
  {
    [JsonProperty("POST:")]
    public ApiRegistrationPost Post { get; set; }
  }

  public partial class ApiRegistrationPost
  {
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("queries")]
    public List<object> Queries { get; set; }

    [JsonProperty("exampleRequestBody")]
    public UserRegistration ExampleRequestBody { get; set; }

    [JsonProperty("exampleResponse")]
    public UserDTO ExampleResponse { get; set; }
  }

  public partial class ApiUserId
  {
    [JsonProperty("GET:")]
    public Post Get { get; set; }
  }

  public partial class Post
  {
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("queries")]
    public List<object> Queries { get; set; }

    [JsonProperty("exampleRequestBody", NullValueHandling = NullValueHandling.Ignore)]
    public UserLogin ExampleRequestBody { get; set; }

    [JsonProperty("exampleResponse")]
    public UserDTO ExampleResponse { get; set; }
  }
}