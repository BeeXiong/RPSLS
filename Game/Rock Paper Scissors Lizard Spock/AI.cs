using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Ai : ParentPlayer
    {
        public Ai()
            
        {
            
        }

        Random rand = new Random();

        public override string GetPlayerName()
        {
            NameAi();
            DisplayAiName();
            return playerName;
        }
        public void NameAi()
        {
            playerName = FindAi();
        }

        public void DisplayAiName()
        {
            Console.WriteLine("You will be playing against {0}", playerName);
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

        public override void MakeSelection()
        {
            Console.WriteLine("Alright it's the {0} turn", playerName); /*error - playerName isnt linked to the instance created in RPSLSactions*/
            GetPlayerSelection(selections[rand.Next(0, 5)]); 
        }

        public override void GetPlayerSelection(string entry)
        {
            playerSelection = entry;
        }

        public void DisplaySelection()
        {
            Console.WriteLine(" {0} picks {1}", playerName, playerSelection); /*error - playerName isnt linked to the instance created in RPSLSactions*/
        }

        public override int TrackScore()
        {
            return playerScore;
        }
    }
}
