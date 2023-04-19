using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class CzyUmieszPotegowac
    {
        /* pierwsza liczba - ilość przypadków, druga to podstawa potęgowania, trzecia to wykładnik
         * program zwraca ostatnie cyfry z liczb będących wynikiem potęgowania
         */
        public int NumberOfCases { get; set; }
        public int[] Cases { get; set; }

        public void InputData(int n)
        {
            n = int.Parse(Console.ReadLine());
            Cases = new int[n];

            for (int i = 0; i < n; i++)
            {
                int baseDigit = int.Parse(Console.ReadLine());
                int expotentialDigit = int.Parse(Console.ReadLine());

                Cases[i] = (int)Math.Pow(baseDigit, expotentialDigit);
            }
        }

        public void DisplayData()
        {
            for (int i = 0; i < Cases.Length; i++)
            {
                char[] tableOfChars = Cases[i].ToString().ToArray();
                Console.WriteLine(tableOfChars[^1]);
            }
        }
    }
}
