using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_Webservices.Models
{
    public class Todo
    {
        public User UserId { get; set; }
        public Int32 Id { get; set; }
        public String Title { get; set; }
        public Boolean Completed { get; set; }

    }
}
