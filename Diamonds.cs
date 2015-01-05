using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamand
{
    class Diamonds
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int outerDots = (input - 1) / 2;
            int innerDots = 1;

            Console.WriteLine("{0}{1}{0}",new string('-',outerDots),"*");
            outerDots--;
            while (outerDots>=0)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outerDots), "*", new string('-', innerDots));
                outerDots--;
                innerDots += 2;
            }
            outerDots+=2;
            innerDots -= 4;
            while (innerDots>=1)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outerDots), "*", new string('-', innerDots));
                outerDots++;
                innerDots -= 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('-', outerDots), "*");
        }
    }
}
