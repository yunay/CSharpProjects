using System;

namespace BitFlipper
{
    class BitFlipper
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int endBit = 62; //64bits - 2 - 1;
            while (endBit>0)
            {
                endBit--;
                ulong last3Bits = (number >> endBit) & 7;
                if (last3Bits == 0 || last3Bits == 7)
                {
                    number = number ^ ((ulong)7 << endBit);
                    endBit -= 2;
                }
            }
            Console.WriteLine(number);
        }
    }
}
