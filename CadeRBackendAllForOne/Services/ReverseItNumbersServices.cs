using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRBackendAllForOne.Services
{
    public class ReverseItNumbersServices
    {
        public string NumReverse(int reverseNum)
        {
            int reversed = 0;

            while (reverseNum>0) 
            {
                reversed = reversed * 10 + reverseNum % 10;
                reverseNum /= 10;
            } 

            reverseNum = reversed;
            return reverseNum.ToString();
        }
    }
}