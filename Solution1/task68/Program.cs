using System;

namespace Ackerman
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
        
        private static int AckermanFunc(int m, int n)
        {
            if (m == 0) return n + 1;
            return n == 0 ? 
                AckermanFunc(m - 1, 1) : 
                AckermanFunc(m - 1, AckermanFunc(m, n - 1));
        }
        
        public static void Main(string[] args)
        {
            var m = GetNumber("Input M value: ",0);
            var n = GetNumber("Input N value: ",0);

            var result = AckermanFunc(m, n);
            Console.Out.WriteLine("Result: " + result);
        }
    }
}