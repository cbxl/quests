using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Mvc.Controllers
{
    public class ArticleController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }


    }
}
