using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Template
{
    internal class End
    {
        public static void EndM()
        {
            Thread.Sleep(1000);
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            var close = "Closing program .";

            foreach (var item in close)
            {
                Thread.Sleep(30);
                Console.Write(item);
            }

            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500);
                Console.Write(" .");
            }
        }
    }
}
