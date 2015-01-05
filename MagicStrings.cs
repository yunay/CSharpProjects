using System;
using System.Collections.Generic;

class MagicStrings
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string[] words = { "s", "n", "k", "p" };
        int[] value = { 3, 4, 1, 5 };
        List<string> newList = new List<string>();
        bool isFind = false;
        for (int i1 = 0; i1 < 4; i1++)
        {
            for (int i2 = 0; i2 < 4; i2++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    for (int i4 = 0; i4 < 4; i4++)
                    {
                        for (int i5 = 0; i5 < 4; i5++)
                        {
                            for (int i6 = 0; i6 < 4; i6++)
                            {
                                for (int i7 = 0; i7 < 4; i7++)
                                {
                                    for (int i8 = 0; i8 < 4; i8++)
                                    {
                                        int rightSide = value[i1] + value[i2] + value[i3] + value[i4];
                                        int leftSide = value[i5] + value[i6] + value[i7] + value[i8];
                                        if (Math.Abs(rightSide - leftSide) == input)
                                        {
                                            string abc = "" + words[i1] + words[i2] + words[i3] +
                                                words[i4] + words[i5] + words[i6] + words[i7] + words[i8];
                                            newList.Add(abc);
                                            isFind = true;
                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        newList.Sort();
        foreach (var item in newList)
        {
            Console.WriteLine(item);
        }

        if (!isFind)
        {
            Console.WriteLine("No");
        }
    }
}

