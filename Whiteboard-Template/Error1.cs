using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Template
{
    internal class Error1
    {
        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var error = "Error: Not an acceptable input!";
            foreach (var item in error)
            {
                Thread.Sleep(30);
                Console.Write(item);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Program.tryAgain2 = true;
        }
    }
}
