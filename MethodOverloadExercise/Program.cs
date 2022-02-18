using System;

namespace MethodOverloadExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 36;
            int b = 1;
            decimal c = 23.45m;
            decimal d = 11.56m;
            bool t = true;
            Console.WriteLine($"int add: {a}+{b}={Add(a, b)} Decimal add: {c}+{d}={Add(c, d)}");
            Console.WriteLine($"{a}+{b}={Add(a, b, t)}");
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool t)
        {
            var sum = x + y;
            if(t == true && sum > 1)
            {
                return $"{sum} dollars. ";
            }
            else if(t == true && sum ==1)
            {
                return $"{sum} dollar. ";
            }
            else if(t == true && sum < 1)
            {
                return $"{sum} dollas. ";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
