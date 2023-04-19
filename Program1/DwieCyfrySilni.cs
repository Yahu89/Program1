using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class DwieCyfrySilni
    {
        /* na wejściu ilość przypadków, następnie liczby, dla których będzie liczona silnia
         * na wyściu programu podana jest cyfra dziesiątek i cyfra jedności dla silni powstałej z podanych wyżej liczb
         */

        public int NumberOfCases { get; set; }
        public int[] Factorial { get; set; }
        public int[] FactorialValue { get; set; }
        public void CalculateDigits(int cases)
        {
            cases = int.Parse(Console.ReadLine());

            Factorial = new int[cases];
            FactorialValue = new int[cases];

            for (int i = 0; i < cases; i++)
            {
                Factorial[i] = int.Parse(Console.ReadLine());

                FactorialValue[i] = 1;

                for (int j = 1; j <= Factorial[i]; j++)
                {                    
                    FactorialValue[i] = FactorialValue[i] * j;
                }
            }
        }

        public void DisplayResult(int n)
        {
            //for (int i = 0; i < FactorialValue.Length; i++)
            //{
            //    Console.WriteLine($"Wartość silnia dla {Factorial[i]} wynosi {FactorialValue[i]}");
            //}

            for (int i = 0; i < FactorialValue.Length; i++)
            {
                char[] tab = FactorialValue[i].ToString().ToArray();

                if (tab.Length < 2)
                {
                    Console.WriteLine(0 + " " + tab[^1]);
                }
                else
                {
                    Console.WriteLine(tab[^2] + " " + tab[^1]);
                }
            }         
        }
    }
}
