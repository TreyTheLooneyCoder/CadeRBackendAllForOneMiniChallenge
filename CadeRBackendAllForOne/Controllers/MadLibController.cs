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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;
        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet]
        [Route("OddEven/{adjective1}/{noun1}/{verb1}/{place}/{adjective2}/{animal}/{verb2}/{noun2}/{emotion}/{verb3}")]
        public string MadLibStory(string adjective1, string noun1, string verb1, string place, string adjective2, string animal, string verb2, string noun2,string emotion,string verb3)
        {
            return _madLibServices.MadLibStory( adjective1,  noun1,  verb1,  place,  adjective2,  animal,  verb2,  noun2, emotion, verb3);
        }
    }
}