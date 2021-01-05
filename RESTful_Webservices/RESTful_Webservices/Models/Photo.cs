using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_Webservices.Models
{
    public class Photo
    {
        public Int32 albumId { get; set; }
        public Int32 id { get; set; }
        public String title { get; set; }
        public String url { get; set; }
        public String thumbnailUrl { get; set; }
    }
}
