using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whiteboard_Template;

namespace Test_Template
{
    internal class UserInput
    {
        public static int Input1 { get; set; }
        public static bool Input2 { get; set; }

        public static void Input()
        {
            Console.Clear();

            var input1 = "Please enter a number: ";


            foreach (var item in input1)
            {
                Thread.Sleep(30);
                Console.Write(item);
            }

            var parse = int.TryParse(Console.ReadLine(), out int input);

            if (parse == true)
            {
                UserInput.Input1 = input;
                Input2 = true;
            }
            else
            {
                Input2 = false;
            }
            
            
        }
    }
}
