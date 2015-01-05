using System;

class TicTacToe
{
    static void Main()
    {
        int inputX = int.Parse(Console.ReadLine());
        int inputY = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        long result = 0;
        int position = inputX + 1;
        if (inputY == 1)
        {
            position = inputX + 4;
        }
        else if (inputY == 2)
        {
            position = inputX + 7;
        }
        n += position - 1;
        result = (long)Math.Pow(n, position);
        Console.WriteLine(result);
    }
}
