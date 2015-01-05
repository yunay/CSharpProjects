using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CrossingSequences
{

    class CrossingSequences
    {
        static void Main()
        {
            BigInteger first = int.Parse(Console.ReadLine());
            BigInteger second = int.Parse(Console.ReadLine());
            BigInteger third = int.Parse(Console.ReadLine());
            BigInteger number = int.Parse(Console.ReadLine());
            BigInteger steps = int.Parse(Console.ReadLine());
            BigInteger sum = 0;
            bool isFind = false;
            bool incresePower = false;
            List<BigInteger> elements = new List<BigInteger>();
            elements.Add(first);
            elements.Add(second);
            elements.Add(third);
            int counter = 1;
            for (int i = 0; i < 1000000; i++)
            {
                sum = first + second + third;
                if (sum > 1000000)
                {
                    break;
                }
                first = second;
                second = third;
                third = sum;
                elements.Add(sum);

            }
            for (int u = 0; u < 1000000; u++)
            {

                if (number == elements[0] || number == elements[1] || number == elements[2])
                {
                    isFind = true;
                    Console.WriteLine(number);
                    return;
                }

                number += steps * counter;
                if (incresePower)
                {
                    counter++;
                }

                for (int i = 0; i < elements.Count; i++)
                {
                    if (number == elements[i])
                    {
                        isFind = true;
                        Console.WriteLine(number);
                        return;
                    }
                }

                incresePower = !incresePower;

            }
            if (isFind == false)
            {
                Console.WriteLine("No");
            }

        }
    }
}
