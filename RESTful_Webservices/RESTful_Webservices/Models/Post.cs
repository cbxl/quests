using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_Webservices.Models
{
    public class Post
    {
        public Int32 userId { get; set; }
        public Int32 id { get; set; }

        public String title { get; set; }

        public String body { get; set; }
    }
}
