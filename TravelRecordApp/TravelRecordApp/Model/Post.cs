using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TravelRecordApp.Model
{
    public class Post
    {
        // Control + . for using SQLite
        [PrimaryKey, AutoIncrement]  
        
        // Type "prop" then tab twice
        public int Id { get; set; }
        [MaxLength(250)]
        public string Experience { get; set; }

        public string VenueName { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string Address { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public int Distance { get; set; }
    }
}
