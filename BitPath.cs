using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitPath
{
    class BitPath
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] bits = new int[8];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] numbers = input.Split(',');
                int startingPos = 3 - int.Parse(numbers[0]);
                bits[0] = bits[0] ^ (1 << startingPos);

                for (int j = 1; j < bits.Length; j++)
                {
                    int currentOffset = int.Parse(numbers[j]);
                    startingPos -= currentOffset;
                    bits[j] = bits[j] ^ (1 << startingPos);
                }
             }
            int sum = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                sum += bits[i];
            }
            Console.WriteLine(Convert.ToString(sum,2));
            Console.WriteLine("{0:X}",sum);
        }
    }
}
