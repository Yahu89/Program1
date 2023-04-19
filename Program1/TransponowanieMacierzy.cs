using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class TransponowanieMacierzy
    {
        public int[,] ArrayOfNumbersBefore { get; set; }
        public int[,] ArrayOfNumbersAfter { get; set; }
        public Random RandomNumbers { get; set; } = new Random();

        public void Solution()
        {
            int i = int.Parse(Console.ReadLine()); // wiersz
            int j = int.Parse(Console.ReadLine()); // kolumna

            ArrayOfNumbersBefore = new int[i, j];
            ArrayOfNumbersAfter = new int[j, i];

            for (int k = 0; k < i; k++)
            {
                for (int l = 0; l < j; l++)
                {
                    ArrayOfNumbersBefore[k, l] = RandomNumbers.Next(1, 101);
                    Console.Write(ArrayOfNumbersBefore[k, l] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int k = 0; k < j; k++)
            {
                for (int l = 0; l < i; l++)
                {
                    ArrayOfNumbersAfter[k, l] = ArrayOfNumbersBefore[l, k];
                    Console.Write(ArrayOfNumbersAfter[k, l] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
