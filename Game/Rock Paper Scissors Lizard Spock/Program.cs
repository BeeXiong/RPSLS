using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanPlayer test = new HumanPlayer();
            Ai testing = new Ai();

            RpslsActions tester = new RpslsActions("test");
            tester.DisplayWelcome();
            tester.SetPlayers();
            tester.NamePlayers();
            tester.ShowGameRules();
            test.MakeSelection();
            
            
         
           



            Console.ReadKey();
            
           
        }
    }
}
