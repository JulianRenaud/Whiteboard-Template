using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whiteboard_Template;

namespace Test_Template
{
    internal class Answer
    {
        public static void AnswerM()
        {
            var logic = new Actual_Logic();




            var answer = logic.Logic(UserInput.Input1);
            Console.Write($"The answer is .");
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500);
                Console.Write(" .");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{answer}!");
            Program.tryAgain1 = false;
        }
    }
}
