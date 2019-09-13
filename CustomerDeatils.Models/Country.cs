using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerDeatils.Models
{
    public class Country
    {
        public Country()
        {
            Cities = new List<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public List<City> Cities { get; set; }
    }
}