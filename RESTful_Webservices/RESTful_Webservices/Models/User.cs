using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_Webservices.Models
{
    public class User
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public Address Address { get; set; }
        public String Phone { get; set; }
        public String WebSite { get; set; }
        public Company Company { get; set; }

        
    }
}
