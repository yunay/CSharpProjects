using System;

namespace FruitMarket
{
    class FruitMarket
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            double sum = 0;
            double price = 0;
            double discount = 0;

            for (int i = 0; i < 3; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                string product = Console.ReadLine();
                bool isFruit = false;
                switch(product)
                {
                    case "banana": price = 1.80; isFruit = true; break;
                    case "orange": price = 1.6; isFruit = true; break;
                    case "apple": price = 0.86; isFruit = true; break;
                    case "cucumber": price = 2.75; isFruit = false; break;
                    case "tomato": price = 3.20; isFruit = false; break;
                }
                switch (dayOfWeek)
                 { 
                    case "Friday":
                         discount = 0.1; 
                         break;
                    case "Sunday":
                         discount = 0.05;
                         break;
                    case "Tuesday":
                         if (isFruit == true)
                         {
                             discount = 0.20;
                         }
                         break;
                    case "Wednesday":
                         if (isFruit == false)
                         {
                             discount = 0.1;
                         }
                         break;
                        default:
                         break;
                }
                if ((dayOfWeek == "Thursday") && (product == "banana"))
                {
                    discount = 0.3;
                }
                sum += quantity*(price-(price * discount));
                discount = 0;
            }
            Console.WriteLine("{0:F2}",sum);
        }
    }
}
