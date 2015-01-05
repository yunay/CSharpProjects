using System;

class Illuminati
{
    static void Main()
    {
        string secretMSG = Console.ReadLine().ToUpper();
        char[] vowel = { 'A', 'E', 'I', 'O', 'U', };
        int sum = 0;
        int counter = 0;
        foreach (var item in secretMSG)
        {
            if (item == 'A'||item == 'E'||item == 'I'||item == 'O'||item == 'U')
            {
                sum += item;
                counter++;
            }
        }
        Console.WriteLine(counter);
        Console.WriteLine(sum);
    }
}

