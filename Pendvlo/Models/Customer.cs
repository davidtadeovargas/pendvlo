using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [MaxLength(60)]
        public string RazonSocial { get; set; }

        [MaxLength(1)]
        [Required]
        public string tipoPersona { get; set; }

        [MaxLength(60)]
        public string Name { get; set; }

        [MaxLength(13)]
        public string RFC { get; set; }

        [MaxLength(60)]
        public string Address { get; set; }

        public int CP { get; set; }

        [MaxLength(25)]
        public string Phone { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(20)]
        public string State { get; set; }

        [MaxLength(50)]
        public string email { get; set; }
        public bool Invoice { get; set; }
        public User SalesMan { get; set; }
        public DateTime Created { get; set; }

        [NotMapped]
        public string CreatedString { set; get; }

        public Customer()
        {
            Created = DateTime.Now;
        }
    }
}