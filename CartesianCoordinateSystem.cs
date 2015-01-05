using System;

namespace CartesianCoordinateSystem
{
    class CartesianCoordinateSystem
    {
        static void Main()
        {
            decimal inputX = decimal.Parse(Console.ReadLine());
            decimal inputY = decimal.Parse(Console.ReadLine());

            if (inputX == 0 && inputY == 0)
            {
                Console.WriteLine(0);
            }
            else if (inputX == 0)
            {
                Console.WriteLine(5);
            }
            else if (inputY == 0)
            {
                Console.WriteLine(6);
            }
            else if (inputX > 0 && inputY > 0)
            {
                Console.WriteLine(1);
            }
            else if (inputX < 0 && inputY > 0)
            {
                Console.WriteLine(2);
            }
            else if (inputX < 0 && inputY < 0)
            {
                Console.WriteLine(3);
            }
            else 
            {
                Console.WriteLine(4);
            }

        }
    }
}
