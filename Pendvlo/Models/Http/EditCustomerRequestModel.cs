using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models.Http
{
    public class EditCustomerRequestModel
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string rfc { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int userID { get; set; }
    }
}