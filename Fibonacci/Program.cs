using System;
/*
50  => 12586269025,
*/
namespace Fibonacci
{
    class Program
    {
        static void Main() {

            Console.Write("Number = ? ");
            _ = long.TryParse(Console.ReadLine(), out long x);
            if (x > 0 && x <= 20) {
                Console.WriteLine("\nFibonacci_Recursive({0}) = {1}", x, Fibonacci(x));

                Console.WriteLine("Factorial: {0}", Factorial(x));
            } else {
                Console.WriteLine("Bad number");
            }


            Console.ReadKey();
        }

        static long Fibonacci(long number) {
            return number switch {
                <= 2 => 1,
                3 => 2,
                _ => Fibonacci(number - 1) + Fibonacci(number - 2)
            };
        }

        static long Factorial(long number) {
            return number switch {
                < 2 => 1,
                _ => number * Factorial(number - 1)
            };
        }
    }
}
