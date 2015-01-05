using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melons_And_Watermelons
{
    class MelonsAndWatermelons
    {
        static void Main()
        {
            int startingDayOfWeek = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int melons = 0;
            int watermelons = 0;
            int counter = 0;
            while (days-1>=counter)
            {
                switch (startingDayOfWeek)
                {
                    case 1:
                        watermelons++; counter++; startingDayOfWeek ++; break;
                    case 2:
                        melons += 2; counter++;startingDayOfWeek ++; break;
                    case 3:
                        watermelons++;  melons++;counter++;startingDayOfWeek ++; break;
                    case 4:
                        watermelons += 2;counter++;startingDayOfWeek ++; break;
                    case 5:
                        watermelons += 2; melons += 2;counter++;startingDayOfWeek ++; break;
                    case 6:
                        watermelons++; melons += 2;counter++;startingDayOfWeek ++; break;
                    case 7:
                        startingDayOfWeek = 1;counter++; break;
                }
            }
            if (watermelons==melons)
            {
                Console.WriteLine("Equal amount: {0}",melons);
            }
            else if (watermelons>melons)
            {
                watermelons = Math.Abs(watermelons - melons);
                Console.WriteLine("{0} more watermelons",watermelons);
            }
            else
            {
                melons = Math.Abs(melons - watermelons);
                Console.WriteLine("{0} more melons", melons);
            }
        }
    }
}
