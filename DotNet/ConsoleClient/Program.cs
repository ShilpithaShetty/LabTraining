// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using RestSharp;
using System.Net.Cache;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

RestClient client = new RestClient();
RestRequest req1 = new RestRequest("https://localhost:7280/api/Name/authenticate", Method.Post);
req1.AddJsonBody(new {
     username= "test1",
     password= "password1"
 });

var response1 = client.Execute(req1);
var token = JsonConvert.DeserializeObject<string>(response1.Content);
Console.WriteLine(token);

RestRequest req2 = new RestRequest("https://localhost:7280/api/Name", Method.Get);
client.AddDefaultHeader("Authorization", $"Bearer {token}");

var response2 = client.Execute(req2);
var content = response2.Content;
Console.WriteLine(content);

Console.WriteLine(response1.Content);
Console.ReadLine();