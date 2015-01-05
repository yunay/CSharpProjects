using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool isFind = false;
        for (int i = 5; i < 10; i++)
        {
            for (int i2 = 5; i2 < 10; i2++)
            {
                for (int i3 = 5; i3 < 10; i3++)
                {
                    int abc = i * 100 + i2 * 10 + i3;
                    for (int i4 = 5; i4 < 10; i4++)
                    {
                        for (int i5 = 5; i5 < 10; i5++)
                        {
                            for (int i6 = 5; i6 < 10; i6++)
                            {
                                int def = i4 * 100 + i5 * 10 + i6;
                                for (int i7 = 5; i7 < 10; i7++)
                                {
                                    for (int i8 = 5; i8 < 10; i8++)
                                    {
                                        for (int i9 = 5; i9 < 10; i9++)
                                        {
                                            int ghi = i7 * 100 + i8 * 10 + i9;
                                            if ((i+i2+i3+i4+i5+i6+i7+i8+i9==sum)&&(def-abc == diff)&&(ghi-def==diff))
                                            {
                                                Console.WriteLine(""+i+i2+i3+i4+i5+i6+i7+i8+i9);
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
        }
        if (!isFind)
        {
            Console.WriteLine("No");
        }
    }
}

