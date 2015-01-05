using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class MorseCode
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
           
            bool isFind = false;
            string[] morseCodes = { "-----", ".----", "..---", "...--", "....-", "....." };
            int nSum = 0;
            while (input > 0)
            {
                nSum += input % 10;
                input /= 10;
            }
                        
            for (int i1 = 0; i1 <= 5; i1++)
            {
                for (int i2 = 0; i2 <= 5; i2++)
                {
                    for (int i3 = 0; i3 <= 5; i3++)
                    {
                        for (int i4 = 0; i4 <=5; i4++)
                        {
                            for (int i5 = 0; i5 <= 5; i5++)
                            {
                                for (int i6 = 0; i6 <= 5; i6++)
                                {
                                    int morseProduct = i1*i2*i3*i4*i5*i6;
                                    if (nSum == morseProduct)
                                    {
                                        Console.WriteLine(
                                        morseCodes[i1] + "|" +
                                        morseCodes[i2] + "|" +
                                        morseCodes[i3] + "|" +
                                        morseCodes[i4] + "|" +
                                        morseCodes[i5] + "|" +
                                        morseCodes[i6] + "|");
                                        isFind = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!isFind)
            {
                Console.WriteLine("No");
            }
        }
    }
}
