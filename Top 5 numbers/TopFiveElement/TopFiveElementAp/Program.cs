using System;
using System.Collections.Generic;
using System.Linq;

namespace TopFiveElementAp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 78, -9, 0, 23, 54, 21, 7, 86 };
            var sortedNumbers = numbers.OrderByDescending(number=>number).Take(5);

        }
    }
}