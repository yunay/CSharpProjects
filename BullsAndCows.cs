using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BullsAndCows
{
    static void Main()
    {
        string secretNumber = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        string output = "";
        bool counter = false;
        List<int> secretNList = new List<int>();
        List<int> guessList = new List<int>();

        for (int i = 1; i < 10; i++)
        {
            for (int i2 = 1; i2 < 10; i2++)
            {
                for (int i3 = 1; i3 < 10; i3++)
                {
                    for (int i4 = 1; i4 < 10; i4++)
                    {
                        int bullsCounter = 0;
                        int cowsCounter = 0;
                        string guess = "" + i + i2 + i3 + i4;
                        for (int t = 0; t < 4; t++)
                        {
                            secretNList.Add(secretNumber[t]);
                            guessList.Add(guess[t]);
                        }
                        for (int e = 3; e >= 0; e--)
                        {
                            if (guess[e]==secretNumber[e])
                            {
                                bullsCounter++;
                                secretNList.RemoveAt(e);
                                guessList.RemoveAt(e);
                            }
                        }
                        for (int p = 0; p < guessList.Count; p++)
                        {
                            if (secretNList.Contains(guessList[p]))
                            {
                                cowsCounter++;
                                secretNList.Remove(guessList[p]);
                            }
                        }
                        if (bulls==bullsCounter&&cows==cowsCounter)
                        {
                            output += guess + " ";
                            counter = true;
                        }
                        secretNList.Clear();
                        guessList.Clear();
                    }
                }
            }
        }
        if (counter==false)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(output.Trim());
        }
    }
}

