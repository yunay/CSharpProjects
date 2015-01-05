using System;

class PokerStraight
{
    static void Main()
    {
        int inputN = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i1 = 1; i1 <= 10; i1++)
        {
            for (int u1 = 1; u1 <= 4; u1++)
            {
                for (int u2 = 1; u2 <= 4; u2++)
                {
                    for (int u3 = 1; u3 <= 4; u3++)
                    {
                        for (int u4 = 1; u4 <= 4; u4++)
                        {
                            for (int u5 = 1; u5 <= 4; u5++)
                            {
                                int sum = (i1 * 10 + u1) + ((i1 + 1) * 20 + u2) + ((i1 + 2) * 30 + u3) + ((i1 + 3) * 40 + u4) + ((i1 + 4) * 50 + u5);
                                if (sum == inputN)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}

