using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class StringMerge
    {
        public int NumberOfCases { get; set; }
        public string[] ArrayOfStrings { get; set; }

        public void InputData()
        {
            NumberOfCases = int.Parse(Console.ReadLine());
            ArrayOfStrings = new string[NumberOfCases * 2];

            for (int i = 0; i < NumberOfCases * 2; i++)
            {
                ArrayOfStrings[i] = Console.ReadLine();
                ArrayOfStrings[i + 1] = Console.ReadLine();
                i++;
            }
        }

        public void DisplayData()
        {
            for (int i = 0; i < NumberOfCases * 2; i++)
            {
                int shorterString = Math.Min(ArrayOfStrings[i].Length, ArrayOfStrings[i + 1].Length);
                int j = 0;
                StringBuilder sb = new StringBuilder();

                while (j < shorterString)
                {
                    sb.Append(ArrayOfStrings[i][j]);
                    sb.Append(ArrayOfStrings[i+1][j]);
                    j++;
                }

                Console.WriteLine(sb);

                i++;
            }
        }
    }
}
