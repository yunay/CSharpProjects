using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;



namespace Cinema
{
    class Cinema
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = 0;
            
            if (projection =="Premiere")
            {
                income = rows * columns * 12;
            }
            else if (projection == "Discount")
            {
                income = rows * columns * 5;
            }
            else
            {
                income = rows * columns * 7.5;
            }
            Console.WriteLine("{0:0.00} leva",income);
        }
    }
}
