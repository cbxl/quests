using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Razor_templating.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_templating.Controllers
{
    public class ExpenditureController : Controller
    {

        public IActionResult Index()
        {
            List<ExpenditureModel> expenditures = new List<ExpenditureModel>
            {new ExpenditureModel{Name ="PC", Date = "07/12/20", Price = 150.20 },
            new ExpenditureModel{Name ="table", Date = "06/12/20", Price = 100.20 },
            new ExpenditureModel{Name ="chaise", Date = "04/12/20", Price = 10.80 }
            };

            return View(expenditures);
        }

        
    }
}
