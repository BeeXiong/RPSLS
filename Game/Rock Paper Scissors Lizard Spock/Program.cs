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

            RpslsActions tester = new RpslsActions();

            test.MakeSelection();
            testing.MakeSelection();
            tester.FindGameWinner();
            
         
           



            Console.ReadKey();
            
           
        }
    }
}
