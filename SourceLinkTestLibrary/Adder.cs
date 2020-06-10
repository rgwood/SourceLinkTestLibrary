using System;

namespace SourceLinkTestLibrary
{
    static public class Adder
    {
        static public int Add(int x, int y)
        {
            Console.WriteLine($"I'm about to add {x} to {y}!");
            return x + y;
        }
    }
}