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
    public class PhotoController : Controller
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
                string responseUsers = _client.DownloadString(_uri + "albums?userId=" + id);
                List<Album> albumsList = JsonConvert.DeserializeObject<List<Album>>(responseUsers);

                List<Photo> photosOfUser = new List<Photo>();

                foreach (Album album in albumsList)
                {
                    string albumId = Convert.ToString(album.id);
                    string responsePhotos= _client.DownloadString(_uri + "photos?albumId=" + albumId);
                    List<Photo> photo = JsonConvert.DeserializeObject<List<Photo>>(responsePhotos);

                    foreach (Photo p in photo)
                    {
                        photosOfUser.Add(p);
                    }

                }

                return View(photosOfUser);
            }

        }
    }

}
