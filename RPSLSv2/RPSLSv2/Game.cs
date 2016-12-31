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
            gameChoices = new List<string>() { "rock", "paper", "scissors", "spock", "lizard" };
        }
        public void runGameLoop()
        {
            displayWelcome();
            RequestToProceed();
            ClearScreen();
            int numberOfPlayers;
            numberOfPlayers = determinePlayers();
            ClearScreen();
            NamePlayers(numberOfPlayers);
            int roundSelection;
            roundSelection = determineGameRounds();
            setStartingScore(firstPlayer, secondPlayer);
            ClearScreen();   
            while (firstPlayer.playerScore < roundSelection && secondPlayer.playerScore < roundSelection)
            {
                if (numberOfPlayers == 2)
                {
                    promptSelection(firstPlayer);
                    makeSelection(firstPlayer);
                    promptSelection(secondPlayer);
                    makeSelection(secondPlayer);   
                }
                else if(numberOfPlayers == 1)
                {
                    promptSelection(firstPlayer);
                    makeSelection(firstPlayer);
                    MakeAiSelection(secondPlayer);  
                }
                int result;
                result = comparePlayerSelections(firstPlayer, secondPlayer);
                RequestToProceed();
                AssignRoundPoints(result, firstPlayer, secondPlayer);
                DisplayScore(firstPlayer,secondPlayer);
                RequestToProceed();
                ClearScreen();
            }
            DetermineGameWinner(firstPlayer,secondPlayer);
            DisplayRestartMessage();
            Console.ReadKey();
        }
        public void displayWelcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock ");
            Console.WriteLine("\r\nHere are the rules!");
            Console.WriteLine("\r\nPlayers make their choice and...");
            Console.WriteLine("\r\nPaper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissorsr");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paperr");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Rock crushes Scissors");
        }
        public int determinePlayers()
        {
            Console.WriteLine("\r\nHow many players will be playing?");
            Console.WriteLine("Please type '1' or '2'");
            string userInput;
            userInput = Console.ReadLine();
            if (userInput == "1" || userInput == "2")
            {
                try
                {
                    int numberOfPlayers;
                    int.TryParse(userInput, out numberOfPlayers);
                    return numberOfPlayers;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Not a valid selection. Please try again.");
                    determinePlayers();
                }
            }
            else
            {
                Console.WriteLine("Invalid Selection. Please type either '1' or '2'");
                determinePlayers();
            }
            return default(int);
        }
        public void setStartingScore(Player firstGamePlayer, Player secondGamePlayer)
        {
            firstGamePlayer.playerScore = 0;
            secondGamePlayer.playerScore = 0;
        }
        public void NamePlayers(int userInput)
        {
            if (userInput == 2)
            {
                firstPlayer = new Player();
                secondPlayer = new Player();
                Console.WriteLine("\r\nPlease type the name for the first player");
                firstPlayer.playerName = Console.ReadLine().ToLower();
                Console.WriteLine("\r\nPlease type the name for the second player");
                secondPlayer.playerName = Console.ReadLine().ToLower();
            }
            if (userInput == 1)
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
        public int determineGameRounds()
        {
            Console.WriteLine("\r\nPlease select the number of rounds required to win");
            int totalRounds;
            totalRounds = Convert.ToInt32(Console.ReadLine());
            return totalRounds;
        }
        public void promptSelection(Player gamePlayer)
        {
            Console.WriteLine("\r\nOkay {0}, please make your selection",gamePlayer.playerName);
        }
        public string makeSelection(Player gamePlayer)
        {
            Console.WriteLine("\r\nPlease pick either 'Rock' - 'Paper' - 'Scissors' - 'Lizard' or 'Spock'");        
            gamePlayer.playerGameSelection = Console.ReadLine().ToLower();
            switch (gamePlayer.playerGameSelection)
            {
                case "rock":
                case "paper":
                case "scissors":
                case "lizard":
                case "spock":
                    Console.Clear();
                    return gamePlayer.playerGameSelection;
                default:
                    Console.WriteLine("Invalid Selection - Please pick either 'Rock' - 'Paper' - 'Scissors' - 'Lizard' or 'Spock'");
                    makeSelection(gamePlayer);
                    break;              
            }
            return gamePlayer.playerGameSelection;
        }
        public string MakeAiSelection(Player gamePlayer)
        {
            Console.WriteLine("\r\nAlright it's the {0} turn", gamePlayer.playerName);
            Random rand = new Random();
            
            gamePlayer.playerGameSelection = (gameChoices[rand.Next(0, 5)]);
            Console.WriteLine("{0} selected {1}", gamePlayer.playerName, gamePlayer.playerGameSelection);
            return gamePlayer.playerGameSelection ;
        }
        public int comparePlayerSelections(Player firstPlayer, Player secondPlayer)
         {
            int firstPlayerChoice;
            int secondPlayerChoice;
            firstPlayerChoice = gameChoices.IndexOf(firstPlayer.playerGameSelection);
            secondPlayerChoice = gameChoices.IndexOf(secondPlayer.playerGameSelection);
            int result;
            result = (5 + gameChoices.IndexOf(firstPlayer.playerGameSelection) - gameChoices.IndexOf(secondPlayer.playerGameSelection)) % 5;
            return result;
        }
        public void AssignRoundPoints(int result, Player firstPlayer, Player secondPlayer)
        {
            if (result % 2 != 0)
            {
                Console.WriteLine("\r\nCongrats {0}, you are the winner!", firstPlayer.playerName);
                firstPlayer.playerScore++;
            }
            else if (result % 2 == 0 && result != 0)
            {
                Console.WriteLine("\r\nCongrats {0}, you are the winner!", secondPlayer.playerName);
                secondPlayer.playerScore++;
            }
            else if (result == 0)
            {
                Console.WriteLine("\r\nIt's a Tie! please select again!");
            }
            else
            {
                Console.WriteLine("\r\nSomething went wrong. Try again!");
            }
        }
        public void ClearScreen()
        {
            Console.Clear();
        }
        public void RequestToProceed()
        {
            Console.WriteLine("\r\nPress anykey to continue");
            Console.ReadLine();
        }
        public void DisplayScore(Player firstGamePlayer, Player secondGamePlayer)
        {
            Console.WriteLine("\r\nTotal Score:");
            Console.WriteLine("{0} has {1} points",firstGamePlayer.playerName,firstGamePlayer.playerScore);
            Console.WriteLine("{0} has {1} points", secondGamePlayer.playerName, secondGamePlayer.playerScore);
        }
        public void DetermineGameWinner(Player firstGamePlayer, Player secondGamePlayer)
        {
            if (firstGamePlayer.playerScore > secondGamePlayer.playerScore)
            {
                Console.WriteLine("Congrats {0}! You have won the game!!",firstGamePlayer.playerName);
            }
            else if (secondGamePlayer.playerScore > firstGamePlayer.playerScore)
            {
                Console.WriteLine("Congrats {0}! You have won the game!!", secondGamePlayer.playerName);
            }
        }
        public void DisplayRestartMessage()
        {
            Console.WriteLine("\r\nWould you like to play another game? 'Yes' or 'No'");
            string userinput;
            userinput = Console.ReadLine().ToLower();
            switch (userinput)
            {
                case "yes":
                    ClearScreen();
                    runGameLoop();
                    break;
                case "no":
                    Console.WriteLine("\r\nOkay. Thanks for playing");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
