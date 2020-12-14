using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebClient_API_REST.Models;

namespace WebClient_API_REST.Controllers
{
    public class PlanetsController : Controller
    {
        
        public IActionResult Index()
        {

            Console.WriteLine("Indiquez le numéro de la planète souhaitée");
            Int32 planetNumber = Convert.ToInt32(Console.ReadLine());

            WebClient client = new WebClient();

            String planetSelectedResponse = client.DownloadString("https://swapi.dev/api/planets/"+planetNumber+"/");    
            PlanetsModel planetSelected = JsonConvert.DeserializeObject<PlanetsModel>(planetSelectedResponse);           

            return View(planetSelected);
        }
    }
}
