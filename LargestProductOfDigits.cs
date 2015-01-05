using System;
using System.Numerics;

namespace LargestProductOfDigits
{
    class LargestProductOfDigits
    {
        static void Main()
        {
            BigInteger numbers = BigInteger.Parse(Console.ReadLine()); //1231241245123513415123412
            BigInteger newNumber = numbers;
            BigInteger product = 1; 
            BigInteger result=0;

            while (numbers > 0)
            {
                newNumber /= 10;
                numbers = newNumber;
                product = 1;
                for (int i = 0; i < 6; i++)
                {
                    product *= (numbers % 10);
                    numbers /= 10;
                }
                if (product >= result)
                {
                    result = product;
                }
            }
            Console.WriteLine(result);
        }
    }
}
