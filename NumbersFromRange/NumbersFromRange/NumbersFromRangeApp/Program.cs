using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRangeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 67, 92, 153, 15 };
            var solution = NumberFromRange(array);
        }

        public static int[] NumberFromRange(int[] array)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 30 && array[i] < 100)
                {
                    numbers.Add(array[i]);
                }
            }

            return numbers.ToArray();
        }
    }
}