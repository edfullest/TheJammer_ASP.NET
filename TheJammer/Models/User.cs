﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheJammer.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public Int32 Age { get; set; }
        public string Country { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
  
    }
}