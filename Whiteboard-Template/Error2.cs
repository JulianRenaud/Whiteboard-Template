using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Template
{
    internal class Error2
    {
        public static void Error()
        {
            Program.tryAgain2 = true;
            Console.ForegroundColor = ConsoleColor.Red;
            var error2 = "Error: Please enter 'yes' or 'no'!";
            foreach (var item in error2)
            {
                Thread.Sleep(30);
                Console.Write(item);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
