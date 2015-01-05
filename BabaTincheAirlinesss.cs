using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabaTincheAirlinesss
{
    class BabaTincheAirlinesss
    {
        static void Main()
        {
            string[] arrAsFirst = Console.ReadLine().Split(' ');
            string[] arrAsBussiness = Console.ReadLine().Split(' ');
            string[] arrAsEconomy = Console.ReadLine().Split(' ');
            double result=0;

            double[] arrFirst = new double[3];
            arrFirst = Array.ConvertAll(arrAsFirst, double.Parse);
            double[] arrSecond = new double[3];
            arrSecond = Array.ConvertAll(arrAsBussiness, double.Parse);
            double[] arrThird = new double[3];
            arrThird = Array.ConvertAll(arrAsEconomy, double.Parse);

            arrFirst[0] -= arrFirst[1] + arrFirst[2];
            arrSecond[0] -= arrSecond[1] + arrSecond[2];
            arrThird[0] -= arrThird[1] + arrThird[2];

            arrFirst[0] *= 7000;
            arrSecond[0] *= 3500;
            arrThird[0] *= 1000;

            arrFirst[1] *= (7000*0.3);
            arrSecond[1] *= (3500*0.3);
            arrThird[1] *= (1000*0.3);

            arrFirst[2] *= (7000+(7000*0.005));
            arrSecond[2] *= 3500+(3500*0.005);
            arrThird[2] *= 1000+(1000*0.005);

            double firstSum = arrFirst[0] + arrFirst[1] + arrFirst[2];
            double SecondSum = arrSecond[0] + arrSecond[1] + arrSecond[2];
            double thirdSum = arrThird[0] + arrThird[1] + arrThird[2];
            result = firstSum + SecondSum + thirdSum;
            int maxIncome = 233160;
            
            Console.WriteLine(Math.Floor(result));
            Console.WriteLine(maxIncome - Math.Floor(result));

        }
    }
}
