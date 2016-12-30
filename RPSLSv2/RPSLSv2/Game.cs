using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSv2
{
    class Game
    {
        Player firstPlayer;
        Player secondPlayer;
        List<string> gameChoices;
        public Game()
        {
 
        }
        public void runGameLoop()
        {
            displayWelcome();
            string numberOfPlayers;
            numberOfPlayers = determinePlayers();
            NamePlayers(numberOfPlayers);
            promptSelection(firstPlayer);
            makeSelection(firstPlayer);
            promptSelection(secondPlayer);
            makeSelection(secondPlayer);

            Console.ReadKey();
        }
        public void displayWelcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock ");
            Console.WriteLine("\r\nHere are the rules!");
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
        public string determinePlayers()
        {
            Console.WriteLine("\r\nHow many players will be playing?");
            Console.WriteLine("Please type '1' or '2'");
            string userInput;
            userInput = Console.ReadLine().ToLower();
            return userInput;
        }
        public void NamePlayers(string userInput)
        {
            if (userInput == "2")
            {
                firstPlayer = new Player();
                secondPlayer = new Player();
                Console.WriteLine("\r\nPlease type the name for the first player");
                firstPlayer.playerName = Console.ReadLine().ToLower();
                Console.WriteLine("\r\nPlease type the name for the second player");
                secondPlayer.playerName = Console.ReadLine().ToLower();
            }
            if (userInput == "1")
            {
                firstPlayer = new Player();
                secondPlayer = new Player();
                Console.WriteLine("\r\nPlease type the name for the first player");
                firstPlayer.playerName = Console.ReadLine().ToLower();
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 100);

                if (randomNumber >= 76)
                {
                    secondPlayer.playerName = "Sheldon";
                }
                else if (randomNumber >= 51)
                {
                    secondPlayer.playerName = "Lenoard";
                }
                else if (randomNumber >= 25)
                {
                    secondPlayer.playerName = "Raj";
                }
                else
                {
                    secondPlayer.playerName = "Penny";
                }
                Console.WriteLine("\r\nYou will be playing against {0}", secondPlayer.playerName);
            }
        }
        public void promptSelection(Player gamePlayer)
        {
            Console.WriteLine("Okay {0}, please make your selection",gamePlayer.playerName);
        }
        public string makeSelection(Player gamePlayer)
        {
            Console.WriteLine("Please pick either 'Rock' - 'Paper' - 'Scissors' - 'Lizard' or 'Spock'");
            
            gamePlayer.playerGameSelection = Console.ReadLine();
            Console.Clear();
            return gamePlayer.playerGameSelection;
            
        }
        public Player comparePlayerSelections(Player firstPlayer, Player secondPlayer)
        {

            return firstPlayer;
        }
        public int assignRoundPoints(Player gamePlayer)
        {
            int roundPoint;
            roundPoint = 1;
            return roundPoint;
        }
        public bool determineWinner(Player gamePlayer)
        {
            return true;
        } 
    }
}
