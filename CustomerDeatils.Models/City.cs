using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerDeatils.Models
{
    public class City
    {
        public City()
        {
            Customers = new List<Customer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<Customer> Customers { get; set; }
    }
}