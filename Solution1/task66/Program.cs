using System;

namespace SumNatural
{
    internal class Program
    {
        private static int GetNumber(string greeting, int lowRange)
        {
            int range;
            do {
                Console.Write(greeting);
                range = int.Parse(Console.ReadLine());
            }  while (range < lowRange);
            return range;
        }
        
        private static int SumNatural(int start, int end)
        {
            if (start == end) return end;

            return start + SumNatural(start + 1, end);
        }
        
        public static void Main(string[] args)
        {
            var lo = GetNumber("Input lo range: ",1);
            var hi = GetNumber("Input hi range: ",1);
            if (lo > hi)
            {
                Console.Out.WriteLine("Lo should be less than HI");
                return;
            }
            var result = SumNatural(lo, hi);
            Console.Out.WriteLine("Result: " + result);
        }
    }
}
