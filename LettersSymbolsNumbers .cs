using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LettersSymbolsNumbers
{
    class Program
    {
        static void Main()
        {
            long letters = 0;
            long numbers = 0;
            long symbols = 0;
            int nLines = int.Parse(Console.ReadLine());
            string text = "";
            for (int i = 0; i < nLines; i++)
            {
                text = Console.ReadLine().ToUpper();
                text = Regex.Replace(text, "\\s+", "");
                for (int u = 0; u < text.Length; u++)
                {
                    char ch = text[u];
                    if (ch >= 'A' && ch <= 'Z')
                    {
                        letters += (ch - 'A' + 1) * 10;
                    }
                    else if (ch >= '0' && ch <= '9')
                    {
                        numbers += (ch-'0') * 20;
                    }
                    else
                    {
                        symbols += 200;
                    }
                }
            }
            Console.WriteLine(letters);
            Console.WriteLine(numbers);
            Console.WriteLine(symbols);
        }
    }
}
