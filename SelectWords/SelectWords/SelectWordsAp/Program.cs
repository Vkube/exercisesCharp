using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectWordsAp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SelectedWord
            var words = new List<string>() { "mum", "amsterdam", "bloom" };
            var selectedWord = words.Where(word => word.StartsWith("a") && word.EndsWith("m"));
        }
    }
}