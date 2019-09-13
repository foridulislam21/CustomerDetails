using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CustomerDeatils.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MobileNo { get; set; }
        public string Email { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}