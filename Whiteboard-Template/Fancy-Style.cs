using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test_Template
{
    internal class Fancy_Style
    {
        private void Fancy()
        {
            var hi = "hi .";
            
            foreach (var item in hi)
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
