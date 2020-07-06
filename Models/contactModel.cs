using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nbcc.Models
{
    public class contactModel
    {

        public int id { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public string subjects { get; set; }
        public string msg { get; set; }
    }
}