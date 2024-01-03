using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Register.Models
{
    public class UserInsert
    {
        [Required(ErrorMessage = "Enter the name")]
        public string name { set; get; }
        [Range(18, 30, ErrorMessage = "Enter the age")]
        public int age { set; get; }
        [Required(ErrorMessage = "Enter the address")]
        public string address { set; get; }
        [EmailAddress(ErrorMessage = "Enter valid email address")]
        public string email { set; get; }
        [Required(ErrorMessage = "Add a photo")]
        public string photo { set; get; }
        [Required(ErrorMessage = "Enter the username")]
        public string username { set; get; }
        public string password { set; get; }
        [Compare("password", ErrorMessage = "Password mismatch")]
        public string cpassword { set; get; }
        public string message { set; get; }
    }
}