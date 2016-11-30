using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{ 
    public class HumanPlayer : ParentPlayer
    {

        public HumanPlayer()
                
        {
            
        }

        public override string GetPlayerName()
        {
            playerName = Console.ReadLine();
            return playerName;
        }

        //public void DisplaySelection()
        //{
        //    Console.WriteLine("If this picks the right one it will show {0}", playerSelection);
        //}

        public override void GetPlayerSelection(string entry)
        {
            playerSelection = entry;
        }

        public override void MakeSelection()

        {
            Console.WriteLine("Please make your selection: 'Rock' - 'Paper' - 'Scissors' - 'Lizard' - 'Spock' ");
            string userinput = Console.ReadLine().ToLower();
            switch (userinput)
            {
                case "rock":
                    GetPlayerSelection(userinput);
                    break;
                case "paper":
                    GetPlayerSelection(userinput);
                    break;
                case "scissors":
                    GetPlayerSelection(userinput);
                    break;
                case "lizard":
                    GetPlayerSelection(userinput);
                    break;
                case "spock":
                    GetPlayerSelection(userinput);
                    break;
                default:
                    Console.WriteLine("Not a valid selection. Please try again.");
                    MakeSelection();
                    break;
            }

        }
        public override int TrackScore()
        {
            return playerScore;
        }






    }
}
