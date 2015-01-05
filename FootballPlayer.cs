using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FootballPlayer
{
    static void Main()
    {
        string typeOfYear = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int htWeekends = int.Parse(Console.ReadLine());
        int result = 0;
        if (typeOfYear=="t")
	    {
            result = (((52 - htWeekends) * 2) / 3)+htWeekends + (holidays / 2)+3;
	    }
        else
        {
            result = (((52 - htWeekends) * 2) / 3) + htWeekends + (holidays / 2);
        }
        Console.WriteLine(result);
    }
}

