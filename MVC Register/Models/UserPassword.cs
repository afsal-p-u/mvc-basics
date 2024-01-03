using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Register.Models
{
    public class UserPassword
    {
        public string oldpassword { set; get; }
        [Required(ErrorMessage = "Enter the password")]
        public string newpassword { set; get; }
        [Compare("newpassword", ErrorMessage ="Password mismatch")]
        public string confirmpassword { set; get; }
        public string message { set; get; }
    }
}