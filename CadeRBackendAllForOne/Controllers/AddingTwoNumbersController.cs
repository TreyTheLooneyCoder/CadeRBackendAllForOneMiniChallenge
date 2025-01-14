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
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersServices _addingTwoNumbersServices;
        public AddingTwoNumbersController(AddingTwoNumbersServices addingTwoNumbersServices)
        {
            _addingTwoNumbersServices = addingTwoNumbersServices;
        }

        [HttpGet]
        [Route("Adding/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2)
        {
            return _addingTwoNumbersServices.AddTwoNumbers(num1, num2);
        }
    }
}