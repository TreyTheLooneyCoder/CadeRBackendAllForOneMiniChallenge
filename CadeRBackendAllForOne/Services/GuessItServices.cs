using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRBackendAllForOne.Services
{
    public class GuessItServices
    {
        public string GuessItEasy(string userEasyGuess)
        {
            Random rng = new Random();
            int easyRandomNum = rng.Next(11);
            int userEasyGuessInt;
            bool converted = int.TryParse(userEasyGuess, out userEasyGuessInt);
            
            if(!converted)
            {
                return "input a number";
            }
            else if(userEasyGuessInt == easyRandomNum)
            {
                return "Correct you got it!";
            }
            else if(userEasyGuessInt < easyRandomNum)
            {
                return $"Too low, the number was {easyRandomNum}.";
            }
            else
            {
                return $"Too high, the number was {easyRandomNum}.";
            }
        }

        public string GuessItMed(string userMediumGuess)
        {
            Random rng = new Random();
            int medRandomNum = rng.Next(51);
            int userMedGuessInt;
            bool converted = int.TryParse(userMediumGuess, out userMedGuessInt);
            
            if(!converted)
            {
                return "input a number";
            }
            else if(userMedGuessInt == medRandomNum)
            {
                return "Correct you got it!";
            }
            else if(userMedGuessInt < medRandomNum)
            {
                return $"Too low, the number was {medRandomNum}.";
            }
            else
            {
                return $"Too high, the number was {medRandomNum}.";
            }
        }

        public string GuessItHard(string userHardGuess)
        {
            Random rng = new Random();
            int hardRandomNum = rng.Next(101);
            int userHardGuessInt;
            bool converted = int.TryParse(userHardGuess, out userHardGuessInt);
            
            if(!converted)
            {
                return "input a number";
            }
            else if(userHardGuessInt == hardRandomNum)
            {
                return "Correct you got it!";
            }
            else if(userHardGuessInt < hardRandomNum)
            {
                return $"Too low, the number was {hardRandomNum}.";
            }
            else
            {
                return $"Too high, the number was {hardRandomNum}.";
            }
        }
    }
}