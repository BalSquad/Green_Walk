using GreenWalk.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

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
                catch(Exception e)
                {
                    Debug.WriteLine(e.Message);
                    Debug.WriteLine(e.InnerException.Message);
                }
                return journeys;
            }
        }

    }
}
