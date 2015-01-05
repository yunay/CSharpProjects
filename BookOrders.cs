using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BookOrders
{
    static void Main()
    {
        int numberOfOrders = int.Parse(Console.ReadLine());
        double bookPrice = 0;
        int numberOfPackets = 0;
        int booksPerPacket = 0;
        double numberOfBooks = 0;
        double result = 0;
        double books = 0;
        double finalResult = 0;
        for (int i = 0; i < numberOfOrders; i++)
        {
            numberOfPackets = int.Parse(Console.ReadLine());
            booksPerPacket = int.Parse(Console.ReadLine());
            bookPrice = double.Parse(Console.ReadLine());
            numberOfBooks = booksPerPacket * numberOfPackets;
            
            if (numberOfPackets >= 10 && numberOfPackets <= 19)
            {
                result = numberOfBooks * (bookPrice - (bookPrice * 0.05));
            }
            else if (numberOfPackets >= 20 && numberOfPackets <= 29)
            {
                result = numberOfBooks * (bookPrice - (bookPrice * 0.06));
            }
            else if (numberOfPackets >= 30 && numberOfPackets <= 39)
            {
                result = numberOfBooks * (bookPrice - (bookPrice * 0.07));
            }
            else if (numberOfPackets >= 40 && numberOfPackets <= 49)
            {
                result = numberOfBooks * (bookPrice - (bookPrice * 0.08));
            }
            else if (numberOfPackets >= 50 && numberOfPackets <= 59)
            {
                result = numberOfBooks * (bookPrice - (bookPrice * 0.09));
            }
            else if (numberOfPackets >= 60 && numberOfPackets <= 69)
            {
                result = numberOfBooks * (bookPrice - (bookPrice * 0.10));
            }
            else if (numberOfPackets >= 70 && numberOfPackets <= 79)
            {
                result = numberOfBooks * (bookPrice - (bookPrice * 0.11));
            }
            else if (numberOfPackets >= 80 && numberOfPackets <= 89)
            {
                result = numberOfBooks * (bookPrice - (bookPrice * 0.12));
            }
            else if (numberOfPackets >= 90 && numberOfPackets <= 99)
            {
                result = numberOfBooks * (bookPrice - (bookPrice * 0.13));
            }
            else if (numberOfPackets >= 100 && numberOfPackets <= 109)
            {
                result = numberOfBooks * (bookPrice - (bookPrice * 0.14));
            }
            else if (numberOfPackets >= 110)
            {
                result = numberOfBooks * (bookPrice - (bookPrice * 0.15));
            }
            else
            {
                result = numberOfBooks * bookPrice;
            }
            finalResult += result;
            books += numberOfBooks;
        }
        
        Console.WriteLine(books);
        Console.WriteLine("{0:F2}",finalResult);
    }
}

