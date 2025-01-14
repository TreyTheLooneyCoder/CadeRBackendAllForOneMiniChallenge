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
    public class ReverseItLettersController : ControllerBase
    {
        private readonly ReverseItLettersServices _reverseItLettersServices;
        public ReverseItLettersController(ReverseItLettersServices reverseItLettersServices)
        {
            _reverseItLettersServices = reverseItLettersServices;
        }

        [HttpGet]
        [Route("Reversing/{letters}")]
        public string LetterReverse(string letters)
        {
            return _reverseItLettersServices.LetterReverse(letters);
        }
    }
}