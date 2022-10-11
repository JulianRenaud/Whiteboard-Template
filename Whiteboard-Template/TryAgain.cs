using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whiteboard_Template;

namespace Test_Template
{
    internal class TryAgain
    {
        public static void TryAgainM()
        {
            while (Program.tryAgain2)
            {
                Console.WriteLine();
                var tryAgain4 = "Would you like to try again (yes/no): ";
                foreach (var item in tryAgain4)
                {
                    Thread.Sleep(30);
                    Console.Write(item);
                }
                var tryAgain = Console.ReadLine();
                if (tryAgain == "yes")
                {
                    Program.tryAgain1 = true;
                    Program.tryAgain2 = false;
                    Thread.Sleep(1000);
                    Console.Clear();

                }
                else if (tryAgain == "no")
                {
                    Program.tryAgain1 = false;
                    Program.tryAgain2 = false;
                    Confirmation.Confirm();
                    Thread.Sleep(1000);
                    Console.Clear();

                }
                else
                {
                    Error2.Error();
                }

                
            }
        }
    }
}
