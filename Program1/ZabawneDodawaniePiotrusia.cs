using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class ZabawneDodawaniePiotrusia
    {
        public int NumberOfCases { get; set; }
        public int[] ArrayOfNumbers { get; set; }
        public int IterationNumber { get; set; }
        public int Counter { get; set; }

        public void InputData()
        {
            NumberOfCases = int.Parse(Console.ReadLine());
            ArrayOfNumbers = new int[NumberOfCases];

            for (int i = 0; i < NumberOfCases; i++)
            {
                ArrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }
        }

        public void DisplayData()
        {
            for (int i = 0; i < NumberOfCases; i++)
            {
                if (IsPalindrom(ArrayOfNumbers[i], i))
                {
                    Console.WriteLine(ArrayOfNumbers[i] + " " + IterationNumber);
                }
            }
        }

        public bool IsPalindrom(int digit)
        {
            return digit.toString().Equals(digit.toString().Reverse())
        }

        public bool IsPalindrom(int digit, int index)
        {
            Counter = 0;
            IterationNumber = 0;
            string str = digit.ToString();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals(str[str.Length - 1 - i]))
                {
                    Counter++;
                }
                else
                {
                    str = MakeNewNumber(int.Parse(str)).ToString();
                    ArrayOfNumbers[index] = int.Parse(str);
                    Counter = 0;
                    IterationNumber++;
                    i = -1;
                }
            }

            if (Counter == str.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int MakeNewNumber(int index)
        {
            string input = index.ToString();
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);

            int tempNumber = int.Parse(chars);

            int newNumber = index + tempNumber;
            return newNumber;
        }
    }
}
