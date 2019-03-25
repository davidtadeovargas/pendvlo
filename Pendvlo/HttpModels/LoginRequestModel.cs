using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pendvlo.HttpModels
{
    public class LoginRequestModel
    {
        [Required(ErrorMessage = "User is empty")]
        public string user { get; set; }

        [Required(ErrorMessage = "Password is empty")]
        public string password { get; set; }
    }
}