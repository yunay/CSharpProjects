using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int u = 7; u >= 0; u--)
            {
                ++counter;
                if ((step==1)||(counter%step == 1))
                {
                    num = num ^ (1 << u);
                }
            }
            Console.WriteLine(num);
        }

    }
}

