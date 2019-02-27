using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string RazonSocial { get; set; }
        public string Name { get; set; }
        public string RFC { get; set; }
        public string Address { get; set; }
        public int CP { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string email { get; set; }
        public bool Invoice { get; set; }
        public User SalesMan { get; set; }
        public DateTime Created { get; set; }

        public Customer()
        {
            Created = DateTime.Now;
        }
    }
}