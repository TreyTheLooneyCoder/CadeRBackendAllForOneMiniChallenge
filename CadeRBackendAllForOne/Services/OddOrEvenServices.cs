using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRBackendAllForOne.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(int checkedNum)
        {
            checkedNum %= 2;

            if(checkedNum == 0)
            {
                return "Your number is even.";
            }
            else
            {
                return "Your number is odd.";  
            }
        }
    }
}