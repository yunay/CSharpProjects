using System;


class NewHouse
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int innerDots = 1;
        int outerDots = (input - 1)/2;
        for (int i = 0; i < (input+1)/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-',outerDots),new string('*',innerDots));
            outerDots--;
            innerDots += 2;
        }
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("{0}{1}{0}","|",new string('*',input-2));

        }
    }
}

