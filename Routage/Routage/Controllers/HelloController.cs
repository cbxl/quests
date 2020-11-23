using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Routage.Controllers
{
    
    public class HelloController
    {
        public String SayHello()
        {
            return "Hello !";
        }

        public String YellHello()
        {
            return "HELLO !";
        }
    }
}
