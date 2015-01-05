using System;

namespace WinningNumbers
{
    class WinningNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int letSum = 0;
            bool isFind = false;
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (input[i]>='a')
                {
                    ch = (char)((ch - 'a') + 1);
                }
                else
                {
                    ch = (char)((ch - 'A')+1);
                }
                letSum += ch;
            }
            
            for (int i1 = 1; i1 < 10; i1++)
            {
                for (int i2 = 1; i2 < 10; i2++)
                {
                    for (int i3 = 1; i3 < 10; i3++)
                    {
                        for (int i4 = 1; i4 < 10; i4++)
                        {
                            for (int i5 = 1; i5 < 10; i5++)
                            {
                                for (int i6 = 1; i6 < 10; i6++)
                                {
                                    if (i1*i2*i3==letSum && i4*i5*i6==letSum)
                                    {
                                        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}",i1,i2,i3,"-",i4,i5,i6);
                                        isFind = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!isFind)
            {
                Console.WriteLine("No");
            } 
        }
    }
}
