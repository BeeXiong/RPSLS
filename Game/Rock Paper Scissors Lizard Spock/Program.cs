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
            RpslsActions tester = new RpslsActions("test");
            tester.DisplayWelcome();
            tester.SetPlayers();
           

            Ai testing = new Ai("fred", 3);
   




            Console.ReadKey();
            
           
        }
    }
}
