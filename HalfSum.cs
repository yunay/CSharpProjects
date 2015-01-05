using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n * 2];
        int firstSum = 0;
        int secondSum = 0;
        for (int i = 0; i < n * 2; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int u = 0; u < n; u++)
        {
            firstSum += numbers[u];
        }
        for (int p = n; p < n * 2; p++)
        {
            secondSum += numbers[p];
        }
        int diff = Math.Abs(firstSum - secondSum);
        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum={0}",firstSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}",diff);
        }
    }
}

