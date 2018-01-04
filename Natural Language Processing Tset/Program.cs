using System;
using System.Collections.Generic;

namespace Natural_Language_Processing_Tset
{
    class Program
    {
        static void Main(string[] args)
        {
            POSFinder p = new POSFinder();
            List<string> nouns = p.FindNouns("A book is a series of pages assembled for easy portability and reading, as well as the composition contained in it. The most common modern form of book is a codex volume consisting of rectangular paper pages bound on one side, with a heavier cover and spine, so that it can fan open for reading. Books have taken other forms, such as scrolls, leaves on a string, or strips tied together; and the pages have been of parchment, vellum, papyrus, bamboo slips, palm leaves, silk, wood, and other materials.");
            foreach(string s in nouns)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
