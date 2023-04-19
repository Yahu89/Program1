using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Flamaster
    {
        public int NumberOfCases { get; set; }

        public string[] TableOfStrings { get; set; }


        public void InputData()
        {
            NumberOfCases = int.Parse(Console.ReadLine());
            TableOfStrings = new string[NumberOfCases];

            for (int i = 0; i < NumberOfCases; i++)
            {
                TableOfStrings[i] = Console.ReadLine().ToUpper();
            }
        }

        public void PrepareFakeData()
        {
            NumberOfCases = 2;
            TableOfStrings = new string[2]
            {
                "aaabbccxyz",
                "13abcccccdddee"
            };
        }

        private void AppendState(StringBuilder sb, char character, int count)
        {
            if (count <= 2)
            {
                for (int i = 0; i < count; ++i)
                {
                    sb.Append(character);
                }
            }
            else
            {
                sb.Append(character);
                sb.Append(count.ToString());
            }
        }

        private void SolveOne(string s)
        {
            int stringLength = s.Length;

            var sb = new StringBuilder("");

            // AA BBBB C 
            char previousCharacter = s[0];
            int countChars = 1; // Bufer ile razy previousCharacter było do tej pory powtórzone

            for (int i = 1; i < stringLength; i++)
            {
                if (previousCharacter.Equals(s[i]))
                {
                    countChars++;
                }
                else
                {
                    AppendState(sb, previousCharacter, countChars);
                    previousCharacter = s[i];
                    countChars = 1;
                }

            }


            Console.WriteLine(sb.ToString());

        }
        public void Solve()
        {

            for (int i = 0; i < NumberOfCases; i++)
            {
                SolveOne(TableOfStrings[i]);
            }
        }


        //List<string> arrayOfFinalResults = new List<string>();            
        //char[] arrayOfChars;

        //stringLength = table[i].Length;

        //for (int j = 0; j < stringLength; j++)
        //{
        //    if (j < stringLength - 1)
        //    {
        //        if (table[i][j].Equals(table[i][j + 1]))
        //        {
        //            Count++;
        //        }
        //        else
        //        {
        //            if (Count >= 3)
        //            {
        //                ArrayOfFinalResults.Add(table[i][j - 2].ToString() + Count.ToString());
        //            }
        //            else if (Count == 2)
        //            {
        //                ArrayOfFinalResults.Add(table[i][j - 1].ToString());
        //                ArrayOfFinalResults.Add(table[i][j].ToString());
        //            }
        //            else if (Count == 1)
        //            {
        //                ArrayOfFinalResults.Add(table[i][j].ToString());
        //            }

        //            Count = 1;
        //        }
        //    }
        //    else if (j == stringLength - 1)
        //    {
        //        if (Count == 1)
        //        {
        //            ArrayOfFinalResults.Add(table[i][j].ToString());
        //        }
        //        else if (Count == 2)
        //        {
        //            ArrayOfFinalResults.Add(table[i][j - 1].ToString());
        //            ArrayOfFinalResults.Add(table[i][j].ToString());
        //        }
        //        else if (Count >= 3)
        //        {
        //            ArrayOfFinalResults.Add(table[i][j].ToString() + Count.ToString());
        //        }
        //    }
        //}

        //foreach (string str in ArrayOfFinalResults)
        //{
        //    Console.Write(str);
        //}

        //Console.WriteLine();
        //ArrayOfFinalResults.Clear();
    }



}
