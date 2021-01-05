using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RESTful_Webservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RESTful_Webservices.Controllers
{
    public class CommentController : Controller
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
                string responseUsers = _client.DownloadString(_uri + "posts?" + "userId=" + id);
                List<Post> postsList = JsonConvert.DeserializeObject<List<Post>>(responseUsers);

                List<Comment> commentsOfPost = new List<Comment>();

                foreach (Post post in postsList)
                {
                    string postId = Convert.ToString(post.id);
                    string responseComments = _client.DownloadString(_uri + "comments?" + "postId=" + postId);
                    IList<Comment> comment = JsonConvert.DeserializeObject<IList<Comment>>(responseComments);

                    foreach (Comment com in comment)
                    {
                        commentsOfPost.Add(com);
                    }

                }

                return View(commentsOfPost);
            }
            
            
        }

    }
}
