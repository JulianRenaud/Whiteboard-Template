using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Template
{
    public class Intro
    {
        public static void IntroM()
        {
            Console.ForegroundColor = ConsoleColor.White; // Whatever color you want
            Console.BackgroundColor = ConsoleColor.DarkBlue; // Whatever color you want


            Console.Clear();

            var intro = "Hi, cool stuff, this is how it works, Starting program .";


            foreach (var item in intro)
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
