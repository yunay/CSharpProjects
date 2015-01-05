using System;

namespace WeirdCombinations
{
    class WeirdCombinations
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            int input = int.Parse(Console.ReadLine());
            int counter = -1;
            bool isTrue = false;
            for (int i = 0; i < 5; i++)
            {
                for (int u = 0; u < 5; u++)
                {
                    for (int k = 0; k< 5; k++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            for (int m = 0; m < 5; m++)
                            {
                                counter++;
                                if (counter==input)
                                {
                                    Console.WriteLine("{0}{1}{2}{3}{4}", inputStr[i], inputStr[u], inputStr[k], inputStr[l], inputStr[m]);
                                    isTrue = true;
                                }
                            }
                        }
                    }
                }
            }
            if (isTrue==false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
