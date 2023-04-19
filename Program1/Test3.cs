using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Test3
    {
        public int InitialNumber { get; set; }
        public int LastNumber { get; set; }
        public int OneBeforeLastNumber { get; set; }

        List<int> numbers = new List<int>();
        public byte RepeatingCounter { get; set; } = 0;

        public void WorkingTest()
        {
            InitialNumber = int.Parse(Console.ReadLine());

            while (RepeatingCounter < 3)
            {
                numbers.Add(int.Parse(Console.ReadLine()));

                if ((numbers[numbers.Count - 1] == InitialNumber) && numbers[numbers.Count - 2] != InitialNumber)
                {
                    RepeatingCounter++;
                }
            }

            Console.WriteLine("END");
        }
    }
}
