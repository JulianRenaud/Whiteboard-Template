using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Template
{
    internal class Confirmation
    {
        public static void Confirm()
        {
            var repeatConfirm = true;
            while (repeatConfirm)
            {
                var confirm = "Are you sure(yes/no): ";
                Console.WriteLine();
                foreach (var item in confirm)
                {
                    Thread.Sleep(30);
                    Console.Write(item);
                }
                var userInput = Console.ReadLine();
                if (userInput == "yes")
                {
                    repeatConfirm = false;
                }
                else if (userInput == "no")
                {
                    repeatConfirm = false;
                    Program.tryAgain2 = true;
                }
                else
                {
                    Error2.Error();
                    repeatConfirm = true;
                }
            }
        }
    }
}
