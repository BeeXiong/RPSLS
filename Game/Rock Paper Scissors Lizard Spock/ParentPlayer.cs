using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ParentPlayer
    {

        public string playerSelection;
        public string playerName;
        protected int score;
        protected List<string> selections = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public ParentPlayer()
            {
            }

        

        public virtual string GetPlayerName()
        {
            return playerName;
        }

        public virtual void GetPlayerSelection(string userentry)
        {
            Console.WriteLine("If this message is seen, there is a problem with the code.");
            throw new Exception();
        }

        public virtual void MakeSelection()
        {
            Console.WriteLine("If this message is seen, there is a problem with the code.");
            throw new Exception();
        }

        public void TrackScore()
        {

        }
    }
}
