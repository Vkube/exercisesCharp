using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareGreaterAp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 7, 2, 30 };
            var square = numbers.Where(x => x * x > 20).ToList();
            var readableSquare = string.Join(" , ", square);
            
        }
    }
}