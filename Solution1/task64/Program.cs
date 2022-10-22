using System;

namespace ListNatural
{
    internal class Program
    {
        private static int GetNumber(int lowRange)
        {
            int range;
            do {
                Console.Write("Input range: ");
                range = int.Parse(Console.ReadLine());
            }  while (range < lowRange);
            return range;
        }
        
        private static void PrintNatural(int number)
        {
            if (number < 1) return;
            Console.Out.Write(number);
            if (number > 1)
                Console.Out.Write(", ");
            PrintNatural(number - 1);
        }
        
        public static void Main(string[] args)
        {
            PrintNatural(GetNumber(1));
            Console.Out.WriteLine();
        }
    }
}