using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class RpslsActions
    {
        public string comparison;
        
        
        public RpslsActions(string comparison)
        {
            this.comparison = comparison;
        }

        HumanPlayer playerOne = new HumanPlayer("Paper", 0);
        HumanPlayer playerTwo = new HumanPlayer("Rock", 0);
        Ai BangChar = new Ai("Rock", 0);

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock ");
        }

        public void ChooseName()
        {
            Console.WriteLine("Please choose your name");
            playerOne.playerName = Console.ReadLine();
            Console.WriteLine("Alright {0}, Let's get started!", ConvertUpper(playerOne.playerName));
        
        }

        public void ChoosePlayers()
        {
            Console.WriteLine("Player 1 please choose your name");
            playerOne.playerName = Console.ReadLine();
            Console.WriteLine("Player 2 please choose your name");
            playerTwo.playerName = Console.ReadLine();
            Console.WriteLine("Alright {0} and {1}, Let's get started!", ConvertUpper(playerOne.playerName), ConvertUpper(playerTwo.playerName));
        }

        public string ConvertUpper(string text)
        {
            return char.ToUpper((text[0])) + ((text.Length > 1) ? text.Substring(1).ToLower() : string.Empty);
        }
        public void SetPlayers()
        {
            Console.WriteLine("Number of Players? '1' or '2' ");
            string userinput = Console.ReadLine();
            int number;
            int.TryParse(userinput, out number);           
            if (number == 1)
            {
                ChooseName(); 
                BangChar.NameAi();
            }
            else
            {
                ChoosePlayers();
            }
                
        }
        
    }
}
