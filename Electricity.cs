using System;
using System.Linq;

namespace Electricity
{
    class Electricity
    {
        static void Main()
        {
            int floors = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            DateTime time = DateTime.Parse(Console.ReadLine());
            decimal lamps = 100.53m;
            decimal comps = 125.90m;
            decimal wats = 0;
            if ((time.Hour>=14)&&(time.Hour<=18))
            {
                wats = 2 * lamps + 2 * comps;
                wats *= flats * floors;
            }
            if ((time.Hour >= 19) && (time.Hour <= 23))
            {
                wats = 7 * lamps + 6 * comps;
                wats *= flats * floors;
            }
            if ((time.Hour >= 0) && (time.Hour <= 8))
            {
                wats = 1 * lamps + 8 * comps;
                wats *= flats * floors;
            }
            Console.WriteLine("{0} Watts",(int)(wats));
        }
    }
}
