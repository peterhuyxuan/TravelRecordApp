using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TravelRecordApp.Model;

namespace TravelRecordApp.Logic
{
    class VenueLogic
    {
        public async static Task<List<Venue>> GetVenues(double latitude, double longitude)
        {
            List<Venue> venues = new List<Venue>();

            var url = VenueRoot.GenerateURL(latitude, longitude);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                // Use jsonutils.com to look convert JSON to C# values
                var json = await response.Content.ReadAsStringAsync();

                var venueRoot = JsonConvert.DeserializeObject<VenueRoot>(json);

                venues = venueRoot.response.venues as List<Venue>;
            }

            return venues;
        }
    }
}
