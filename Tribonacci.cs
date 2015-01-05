using System;
using System.Numerics;

namespace Tribonacci
{
    class Tribonacci
    {
        static void Main()
        {
            BigInteger first = new BigInteger(int.Parse(Console.ReadLine()));
            BigInteger second = new BigInteger(int.Parse(Console.ReadLine()));
            BigInteger third = new BigInteger(int.Parse(Console.ReadLine()));
            BigInteger nNumber = new BigInteger(int.Parse(Console.ReadLine()));
            
            BigInteger result = 0;

            if (nNumber == 1)
                Console.WriteLine(first);
            else if (nNumber == 2)
                Console.WriteLine(second);
            else if (nNumber == 3)
                Console.WriteLine(third);
            else
            {
                for (int i = 0; i < nNumber - 3; i++)
                {
                    result = first + second + third;
                    first = second;
                    second = third;
                    third = result;
                }
                Console.WriteLine();
                Console.WriteLine(result);
            }
        }
    }
}
