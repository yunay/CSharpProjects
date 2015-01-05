using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphics
{
    class ConsoleGraphics
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*',input*2));
            Console.WriteLine(new string('*', input * 2));
            for (int i = 0; i < input-1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('*', (input + 1) / 2), new string(' ',input-1));
            }
            Console.WriteLine(new string('~', input * 2));
            Console.WriteLine(new string('~', input * 2));
        }
    }
}
