using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIntro.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FName { get; set; }

        public string LName { get; set; }

        public int Age { get; set; }
    }
}