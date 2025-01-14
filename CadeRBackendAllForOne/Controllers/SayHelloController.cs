using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadeRBackendAllForOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadeRBackendAllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloServices _sayHelloServices;
        public SayHelloController(SayHelloServices sayHelloServices)
        {
            _sayHelloServices = sayHelloServices;
        }

        
        [HttpGet]
        [Route("Greetings/{userName}")]
        public string SayHello(string userName)
        {
              
            return _sayHelloServices.SayHello(userName);
        }
    }
}