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
        
        public IActionResult Index()
        {

            return View();
        }
    }
}
