using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Gambling
{
    static void Main()
    {
        double c = double.Parse(Console.ReadLine());
        string[] hand = Console.ReadLine().Split(' ');
        double cardStrength = 0;
        double pot = 2 * c;
        double winningHands = 0;       
        double currentHand = 0;
        const double possibleHands = 28561; //conts = 28561;
        double probability = 0;
        for (int i = 0; i < hand.Length; i++)
        {
            switch (hand[i])
            {
                case "J": cardStrength += 11; break;
                case "Q": cardStrength += 12; break;
                case "K": cardStrength += 13; break;
                case "A": cardStrength += 14; break;
                default: cardStrength += int.Parse(hand[i]); break;
            }
        }
        for (int i1 = 2; i1 <= 14; i1++)
        {
            for (int i2 = 2; i2 <= 14; i2++)
            {
                for (int i3 = 2; i3 <= 14; i3++)
                {
                    for (int i4 = 2; i4 <= 14; i4++)
                    {
                        currentHand = i1 + i2 + i3 + i4;
                        if (currentHand>cardStrength)
                        {
                            winningHands++;
                        }
                    }
                }
            }
        }
        probability = (winningHands / possibleHands)*100;
        double possibleWin = (pot * probability)/100;
        
        if (probability<50)
        {
            Console.WriteLine("FOLD");
            Console.WriteLine("{0:F2}", possibleWin);
        }
        else
        {
            Console.WriteLine("DRAW");
            Console.WriteLine("{0:F2}", possibleWin);
        }
    }
}
