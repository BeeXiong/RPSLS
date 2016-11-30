using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class RpslsActions
    {
        ParentPlayer firstPlayer;
        ParentPlayer secondPlayer;
        ParentPlayer listToCompare;
        public int computedWinner;


        public RpslsActions()
        {
           
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock ");
        }

        public string ConvertUpper(string text)
        {
            return char.ToUpper((text[0])) + ((text.Length > 1) ? text.Substring(1).ToLower() : string.Empty);
        }
        public void SetPlayers()
        {
            Console.WriteLine("Please Choose number of Players? '1' or '2' ");
            string userinput = Console.ReadLine();
            int number;
            int.TryParse(userinput, out number);           
            if (number == 1)
            {
                firstPlayer = new HumanPlayer();
                secondPlayer = new Ai();
            }
            else if (number == 2)
            {
                firstPlayer = new HumanPlayer();
                secondPlayer = new HumanPlayer();
            }
            else
            {
                Console.WriteLine("I'm sorry. I didn't get that. Could you please type '1' or '2' ");
            }
        }
        public void NamePlayers()
        {
            Console.WriteLine("Player 1 please choose your name");
            firstPlayer.GetPlayerName();
            Console.WriteLine("Player 2");
            secondPlayer.GetPlayerName();
            Console.WriteLine("Alright {0} and {1}, Let's get started!", ConvertUpper(firstPlayer.playerName), ConvertUpper(secondPlayer.playerName));
        }
        public void ShowGameRules()
        {
            Console.WriteLine("Here are the rules!");
            Console.WriteLine("Players make their choice and...");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissorsr");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paperr");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Rock crushes Scissors");
        }

        public void GameLoop()
        {
            firstPlayer.MakeSelection();
            secondPlayer.MakeSelection();
            FindGameWinner();

        }

        public void FindGameWinner()
        {
            int index = 0;
            listToCompare = new ParentPlayer();
            
            while (firstPlayer.TrackScore() < 2 && secondPlayer.TrackScore() < 2)
            {
                if (computedWinner % 2 != 0)  
                {
                    Console.WriteLine("Congrats {0}, you are the winner!", firstPlayer);
                    AwardPoints(index++); 
                }
                else if (computedWinner % 2 == 0)
                {
                    Console.WriteLine("Congrats {0}, you are the winner!", secondPlayer);
                    AwardPoints(index++);
                }
                else if (computedWinner == 0)
                {
                    Console.WriteLine("It's a Tie! please select again!");
                }
                else
                {
                    Console.WriteLine("Something went wrong. Try again!");
                }
            }
        }

        public void ComputeSelections(int compute)
        {
            compute = (5 + listToCompare.selections.IndexOf(firstPlayer.playerSelection) - listToCompare.selections.IndexOf(secondPlayer.playerSelection)) % 5;  
        }

        public int GetRoundWinner()
        {
            return computedWinner;
        }
        public int AwardPoints(int score)
        {
            return firstPlayer.TrackScore();
        }


    }
}
