using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRBackendAllForOne.Services
{
    public class ReverseItLettersServices
    {
        public string LetterReverse(string letters)
        {   

            char[] charArray = letters.ToCharArray();
            string reverse = " ";
            for(int i = charArray.Length - 1; i > -1; i--)
            {
                reverse += charArray[i];
            }

            letters = reverse;
            
            if(letters == "")
            {
                return "Left Null.";
            }
            else
            {
                return letters;
            }
        }
    }
}