using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInformation
{
    class AccountInformation
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int clientID = int.Parse(Console.ReadLine());
            decimal accBalance = decimal.Parse(Console.ReadLine());
            string isActive = "no";
            if (accBalance>=0)
            {
                isActive = "yes";
            }
            Console.WriteLine("Hello, {0} {1}",firstName,lastName);
            Console.WriteLine("Client id: {0}",clientID);
            Console.WriteLine("Total balance: {0:F2}",accBalance);
            Console.WriteLine("Active: {0}",isActive);

        }
    }
}
