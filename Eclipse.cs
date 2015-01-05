using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eclipse
{
    class Eclipse
    {
        static void Main()
        {

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}{1}{0}", " ", new string('*', (input * 2) - 2), new string(' ',input+1));
            string newStr = new string(' ', input - 1);
            for (int i = 0; i < input-2; i++)
            {
                if (i == input / 2 - 1)
                {
                    newStr = new string('-', input - 1);
                }
                else
                {
                    newStr = new string(' ', input - 1);
                }
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}","*",new string('/',input*2-2), newStr);
                
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", " ", new string('*', (input * 2) - 2), new string(' ', input + 1));
        }

    }
}
