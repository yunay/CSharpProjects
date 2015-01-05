using System;

namespace BitSequenceExchange
{
    class BitSequenceExchange
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int mask = 1;
            int firstPos = 3;
            int secondPos = 24;
            int thirdPos = 4;
            int fourthPos = 25;
            int fifthPos = 5;
            int sixtPos = 26;

            long firstBit = (n >> firstPos) & mask;
            long secondBit = (n >> secondPos) & mask;
            long thirdBit = (n >> thirdPos) & mask;
            long fourthBit = (n >> fourthPos) & mask;
            long fifthBit = (n >> fifthPos) & mask;
            long sixtBit = (n >> sixtPos) & mask;

            n &= ~(mask << firstPos);
            n |= secondBit << firstPos;
            n &= ~(mask << thirdPos);
            n |= fourthBit << thirdPos;
            n &= ~(mask << fifthPos);
            n |= sixtBit << fifthPos;

            n &= ~(mask << secondPos);
            n |= firstBit << secondPos;
            n &= ~(mask << fourthPos);
            n |= thirdBit << fourthPos;
            n &= ~(mask << sixtPos);
            n |= fifthBit << sixtPos;

            Console.WriteLine(n);
        }
    }
}
