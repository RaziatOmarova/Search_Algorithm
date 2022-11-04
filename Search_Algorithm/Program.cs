using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4] { -1, 2, -3, 4 };
            Console.WriteLine(Find(numbers));
            Console.ReadKey();
        }
        static int Find(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
