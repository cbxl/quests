using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RESTful_Webservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace RESTful_Webservices.Controllers
{
    public class HomeController : Controller
    {
        public WebClient _client = new WebClient();
        public String _uri = "https://jsonplaceholder.typicode.com/";
        
        

        public IActionResult Index(Int32 id)
        {
            if (id <= 0)
            {
                return View();
            }
            else
            {
                string responseUsers = _client.DownloadString(_uri +"users/" + id );
                User user = JsonConvert.DeserializeObject<User>(responseUsers);

                string responsePosts = _client.DownloadString(_uri + "posts/?userId=" + id);
                IEnumerable<Post> post = JsonConvert.DeserializeObject<IEnumerable<Post>> (responsePosts);

                return View(post);
            }
        }

       

    }
}
