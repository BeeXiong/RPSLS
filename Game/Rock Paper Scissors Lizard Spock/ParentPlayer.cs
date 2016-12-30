using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ParentPlayer
    {

        protected string playerSelection;
        public string playerName;
        protected int playerScore;
        public List<string> selections = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public ParentPlayer()
            {
            }

        

        public virtual string GetPlayerName()
        {
            return playerName;
        }

        public virtual void GetPlayerSelection(string entry)
        {
            Console.WriteLine("If this message is seen, there is a problem with the code.");
            throw new Exception();
        }

        public virtual void MakeSelection()
        {
            Console.WriteLine("If this message is seen, there is a problem with the code.");
            throw new Exception();
        }

        public virtual int TrackScore()
        {
            Console.WriteLine("If this message is seen, there is a problem with the code.");
            throw new Exception();
        }
    }
}
