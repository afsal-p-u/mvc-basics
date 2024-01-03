using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Register.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Enter the username")]
        public string username { set; get; }
        [Required(ErrorMessage = "Enter the password")]
        public string password { set; get; }
        public string message { set; get; }
    }
}