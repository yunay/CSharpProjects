using System;

class DNA_No
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char word = char.Parse(Console.ReadLine());
        int counterN = 0;
        int outerDots = 3;
        int innerDots = 1;
        for (int i = 0; i < n; i++)
        {
            while (counterN != n)
            {
                Console.Write(new string('.', outerDots));
                for (int f = 0; f < innerDots; f++)
                {
                    Console.Write(word);
                    word++;
                    if (word>='H')
                    {
                        word = 'A';
                    }
                }
                Console.WriteLine(new string('.', outerDots));
                outerDots--;
                innerDots += 2;
                counterN++;
                if (counterN == n)
                {
                    break;
                }
                if (outerDots == 0)
                {
                   
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(new string('.', outerDots));
                        for (int f = 0; f < innerDots; f++)
                        {
                            Console.Write(word);
                            word++;
                            if (word >= 'H')
                            {
                                word = 'A';
                            }
                        }
                        Console.WriteLine(new string('.', outerDots));
                        outerDots++;
                        innerDots -= 2;
                        counterN++;
                        if (counterN == n)
                        {
                            break;
                        }
                    }
                    
                    if (counterN == n)
                    {
                        break;
                    }
                    counterN++;
                    
                   Console.WriteLine("{0}{1}{0}", new string('.', 3), new string(word++, 1));
                   if (word >= 'H')
                   {
                       word = 'A';
                   }
                }
            }
        }
    }
}
