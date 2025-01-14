using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRBackendAllForOne.Services
{
    public class SayHelloServices
    {
        public string SayHello(string userName)
        {
            if(userName == "")
            {
                return "Input something.";
            }
            else
            {
                return $"Hello {userName}, Nice to see you again.";
            }
        }
    }
}