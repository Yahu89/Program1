using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Podzielnosc
    {
        /* pierwsza liczba to ilość przypadków, następne dane: maksymalna liczba, dla której nastąpi sprawdzanie warunku, druga liczba to dzielnik
         * przez który sprawdzana liczba musi być podzielna, a ostatnia to dzielnik, przez który liczba nie może być podzielna, na wyjściu liczby spełniające
         * powyższe warunki
         */

        public int NumberOfCases { get; set; }
        public int[] ArrayOfNumbers { get; set; }

        public void InputData()
        {
            NumberOfCases = int.Parse(Console.ReadLine());
            ArrayOfNumbers = new int[NumberOfCases * 3];

            for (int i = 0; i < NumberOfCases * 3;)
            {
                ArrayOfNumbers[i] = int.Parse(Console.ReadLine());
                ArrayOfNumbers[i + 1] = int.Parse(Console.ReadLine());
                ArrayOfNumbers[i + 2] = int.Parse(Console.ReadLine());
                i += 3;
            }
        }

        public void DisplayData()
        {
            for (int i = 0; i < NumberOfCases * 3;)
            {
                for (int j = 0; j < ArrayOfNumbers[i]; j++)
                {
                    if (j % ArrayOfNumbers[i + 1] == 0 && j % ArrayOfNumbers[i + 2] != 0)
                    {
                        Console.Write(j + " ");
                    }
                }

                i += 3;
            }
        }
    }
}
