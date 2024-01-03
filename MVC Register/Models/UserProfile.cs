﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Register.Models
{
    public class UserProfile
    {
        public string name { set; get; }
        public int age { set; get; }
        public string address { set; get; }
        public string email { set; get; }
        public string photo { set; get; }
        public string message { set; get; }
    }
}