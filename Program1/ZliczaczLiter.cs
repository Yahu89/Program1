using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class ZliczaczLiter
    {
        public string InputString { get; set; }
        public char[] InputStringDistinct { get; set; }
        public int Counter { get; set; } = 0;

        public void InputData()
        {
            InputString = Console.ReadLine().ToLower();
            InputStringDistinct = InputString.Distinct().ToArray();
        }

        public void CountingLetters()
        {
            foreach (char letter in InputStringDistinct)
            {
                for (int i = 0; i < InputString.Length; i++)
                {
                    if (letter == InputString[i])
                    {
                        Counter++;
                    }
                }

                Console.WriteLine(letter + " " + Counter);
                Counter = 0;
            }
           
        }
    }
}
