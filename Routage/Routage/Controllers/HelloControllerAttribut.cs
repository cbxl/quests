using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Routage.Controllers
{

    public class HelloControllerAttribut : Controller
    {
        [Route("hello")]
        [Route("hello/dit")]
        public String DitHello()
        {
            return "Hello !";
        }

        [Route("hello/crie")]
        public String CrieHello()
        {
            return "HELLO !";
        }
    }

}
