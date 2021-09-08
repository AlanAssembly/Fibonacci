using System;
/*
50  => 12586269025,
*/
namespace Fibonacci
{
    class Program
    {
        static int _i;

        static void Main(string[] args) {

            Console.WriteLine("Number = ? ");
            _ = long.TryParse(Console.ReadLine(), out long x);
            if (x > 0)
            {
                Console.WriteLine("Fibonacci_Recursive({0}) = {1}", x, Fibonacci(x));
            }
        }

        static long Fibonacci(long number) {
            Console.WriteLine($"{++_i}\t{number}");
            return number switch {
                <= 2 => 1,
                3 => 2,
                _ => Fibonacci(number - 1) + Fibonacci(number - 2),
            };
        }
    }
}
