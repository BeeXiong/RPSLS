using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer
    {
        public string playerName;
        public string playerSelection;
        public string playerChoice;
        public int playerScore;
        public int playerPoints;

        public HumanPlayer(string playerName, string playerSelection, string playerChoice, int playerScore, int playerPoints)
        {
            this.playerName = playerName;
            
            this.playerSelection = playerSelection;
            this.playerChoice = playerChoice;
            this.playerScore = playerScore;
            this.playerPoints = playerPoints;
        }
            
        

    }
}
