using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRBackendAllForOne.Services
{
    public class AskingQuestionsServices
    {
        public string AskQuestions(string name, string time)
        {
            if(name == "" || time == "")
            {
                return "Enter something.";
            }
            else
            {
                return $"Hey, your name is {name} and you woke up at {time} today.";
            }
        }
    }
}