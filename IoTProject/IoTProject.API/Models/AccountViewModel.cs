using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoTProject.API.Models
{
    public class AccountViewModel
    {

        public int AccountID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Office { get; set; }

        public int CategoryID { get; set; }
    }
}