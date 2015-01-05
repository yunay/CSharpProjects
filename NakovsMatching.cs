using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NakovsMatching
{
    static void Main()
    {
        string firstStr = Console.ReadLine();
        string secondStr = Console.ReadLine();
        int limitNumber = int.Parse(Console.ReadLine());
        int firstStrSum = 0;
        int secondStrSum = 0;
        string newFirstHalfFirst = "";
        string newSecondHalfFirst = "";
        string newFirstHalfSecond = "";
        string newSecondHalfSecond = "";
        bool isFind = false;
            for (int j = 0; j < secondStr.Length; j++)
            {
                secondStrSum += secondStr[j];
            }
            for (int n = 0; n < firstStr.Length; n++)
            {
                firstStrSum += firstStr[n];
            }
            int firstHalfFirst = 0;
            int secondHalfFirst = firstStrSum;
            int firstHalfSecond = 0;
            int secondHalfSecond = secondStrSum;
            for (int i = 0; i < firstStr.Length; i++)
            {
                firstHalfFirst += firstStr[i];
                secondHalfFirst -= firstStr[i];
                newFirstHalfFirst = firstStr.Substring(0, i+1);
                newSecondHalfFirst = firstStr.Substring(i+1);
                for (int i2 = 0; i2 < secondStr.Length; i2++)
                {
                    firstHalfSecond += secondStr[i2];
                    secondHalfSecond -= secondStr[i2];
                    newFirstHalfSecond = secondStr.Substring(0, i2+1);
                    newSecondHalfSecond = secondStr.Substring(i2+1);
                    int currentLimit = Math.Abs(firstHalfFirst * secondHalfSecond - secondHalfFirst * firstHalfSecond);
                    if (currentLimit <= limitNumber && currentLimit != 0)
                    {
                        Console.WriteLine("({0}{1}{2}) matches ({3}{1}{4}) by {5} nakovs",
                            newFirstHalfFirst, "|", newSecondHalfFirst, newFirstHalfSecond, newSecondHalfSecond, currentLimit);
                        isFind = true;
                    }
                }
                firstHalfSecond = 0;
                secondHalfSecond = secondStrSum;
            }
            if (!isFind)
            {
                Console.WriteLine("No");
            }
    }
}

