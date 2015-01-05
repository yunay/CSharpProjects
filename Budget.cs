using System;

namespace Budget
{
    class Budget
    {
        static void Main()
        {
            int inputN = int.Parse(Console.ReadLine()); //amount of money Kiro has to last the month.
            int inputP = int.Parse(Console.ReadLine()); //number of weekdays Kiro goes out per month.
            int inputH = int.Parse(Console.ReadLine()); //number of weekends that Kiro spends in his hometown.

            int goingOut = (int)(0.03 * inputN)  + 10;
            int weekendsNotHomeTown = 8 - inputH*2;
            int normalDays = 30 - inputP - inputH * 2 - weekendsNotHomeTown;
            int budjet = inputN - 150 - (inputP * goingOut) - (normalDays * 10) - weekendsNotHomeTown*20;

            if (budjet>0)
            {
                Console.WriteLine("Yes, leftover {0}.",budjet);
            }
            else if (budjet<0)
            {
                Console.WriteLine("No, not enough {0}.", budjet*(-1));
            }
            else 
            {
                Console.WriteLine("Exact Budget.");
            }
        }
    }
}
