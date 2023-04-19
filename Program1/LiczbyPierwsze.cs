using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class LiczbyPierwsze
    {
        public void listOfEvenNumbers()
        {
            for (int i = 1; i <= 5000; i++)
            {
                if (i > 9)
                {
                    if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0)
                    {
                        Console.WriteLine(i + " NIE");
                    }
                    else
                    {
                        Console.WriteLine(i + " TAK");
                    }
                }
                else
                {
                    if (i == 1 || i == 2 || i == 3 || i == 5 || i == 7)
                    {
                        Console.WriteLine(i + " TAK");
                    }
                    else
                    {
                        Console.WriteLine(i + " NIE");
                    }
                }
            }
        }
    }
}
