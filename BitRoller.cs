using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitRoller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int freezePosition = int.Parse(Console.ReadLine());
        int times = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < times; i++)
        {
            int nRightP = n >> freezePosition; 
            int bit = nRightP & 1;
            n = n >> 1;
            int mask = (1 << freezePosition);
            result = n | mask;     

        }
        Console.WriteLine(result);
    }
}

