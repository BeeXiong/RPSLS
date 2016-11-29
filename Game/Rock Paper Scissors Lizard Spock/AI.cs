using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Ai : ParentPlayer
    {
        public string AiName;
        public Ai(string playerSelection, int score)
            :base(playerSelection, score)
        {
            
        }

        public void  Selection()
        {

        }

        public void DisplayAiName()
        {
            Console.WriteLine("You will be playing against {0}", AiName);
        }

        public void NameAi()
        {
            AiName = FindAi();
            DisplayAiName();
        }

        public string FindAi()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 100);

            if (randomNumber >= 76)
            {
                return "Sheldon";
            }
            else if (randomNumber >= 51)
            {
                return "Lenoard";
            }
            else if (randomNumber >= 25)
            {
                return "Raj";
            }
            else 
            {
                return "Penny";
            }

        }

    }
}
