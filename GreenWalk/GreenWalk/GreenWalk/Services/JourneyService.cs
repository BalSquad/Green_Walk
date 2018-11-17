using GreenWalkModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;

namespace GreenWalk.Services
{
    public class JourneyService
    {

        public static List<Journey> GetJourneysByUser(int userId)
        {
            using (HttpClient client = new HttpClient())
            {
                List<Journey> journeys = new List<Journey>();
                try
                {
                    var request = new HttpRequestMessage(HttpMethod.Get, $"https://greenwalkapi.azurewebsites.net/api/journey/getallbyuser/2");
                    HttpResponseMessage response = client.SendAsync(request).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        string json = response.Content.ReadAsStringAsync().Result;
                        journeys = JsonConvert.DeserializeObject<List<Journey>>(json);
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    Debug.WriteLine(e.InnerException.Message);
                }
                return journeys;
            }
        }

        public static void CreateJourney(int userId)
        {

            using (HttpClient client = new HttpClient())
            {

                Journey journeys = new Journey
                {
                    UserID = userId,
                    Date = DateTime.Now
                };

                try
                {
                    var dataAsString = JsonConvert.SerializeObject(journeys);
                    var content = new StringContent(dataAsString);
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    var url = "";
                    var response = client.PostAsync(url, content).Result;
                    var result = response.IsSuccessStatusCode ? true : false;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    Debug.WriteLine(e.InnerException.Message);
                }

            }

        }

   
    }
}
