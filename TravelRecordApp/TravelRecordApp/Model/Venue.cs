using System;
using System.Collections.Generic;
using System.Text;
using TravelRecordApp.Helpers;

namespace TravelRecordApp.Model
{
    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
        public int distance { get; set; }
        public string cc { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public IList<string> formattedAddress { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string crossStreet { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public string pluralName { get; set; }
        public string shortName { get; set; }
        public bool primary { get; set; }
    }

    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
        public IList<Category> categories { get; set; }

    }

    public class Response
    {
        public IList<Venue> venues { get; set; }
    }

    class VenueRoot
    {
        public Response response { get; set; }
        public static string GenerateURL(double latitude, double longitude)
        {
            return string.Format(Constants.VENUE_SEARCH, latitude, longitude, Constants.CLIENT_ID, Constants.CLIENT_SECRET, DateTime.Now.ToString("yyyyMMdd"));
        }
    }
}
