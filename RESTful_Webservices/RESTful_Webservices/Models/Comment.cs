using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_Webservices.Models
{
    public class Comment
    {
        public Int32 postId { get; set; }
        public Int32 id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String body { get; set; }
    }
}
