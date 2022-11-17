using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumLengthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string> { "zebra", "elephant", "cat", "dog", "rhino", "bat" };
            MinimumLength(animals);
        }

        private static List<string> MinimumLength(List<string> words)
        {
            var animals = words.Where(word => word.Length >= 5).Select(word => word.ToUpper());
            return animals.ToList();
        }
    }
}