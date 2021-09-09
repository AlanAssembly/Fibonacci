using System;
using System.Numerics;
/*
50  12586269025
48  4807526976 
*/
namespace Fibonacci
{
    class Program
    {
        static void Main() {

            Console.WriteLine("Factorial and Fibionacci Approach");
            while (true) {
                Console.Write("\nNumber = ? ");
                _ = uint.TryParse(Console.ReadLine(), out uint x);
                if (x > 0 && x <= 10000) {
                    Console.WriteLine("\nFibonacci({0}) = {1}", x, Friendly(Fibonacci(x)));
                    Console.WriteLine("Factorial: {0}", Friendly(Factorial(x)));
                } else {
                    Console.WriteLine("Bad number");
                    break;
                }
            }
        }

        #region FIBONACCI
        // the performance degrades incrementally as the numbers are greater than 40, i.g. 48-> 30 s! fatal
        static long FibonacciRecursive(long number) {
            return number switch {
                <= 2 => 1,
                3 => 2,
                _ => FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2)
            };
        }

        // works up to 93!
        public static ulong FibonacciUlong(uint number) {
            ulong a = 0, b = 1, result = 0;
            for (uint i = 0; i <= number; i++) {
                if (i <= 1)
                    result = i;
                else {
                    result = a + b;
                    a = b;
                    b = result;
                }
            }
            return result;
        }

        // final - works up to 10,000 !!!
        public static BigInteger Fibonacci(uint number) {
            BigInteger a = 0, b = 1, result = 0;
            for (uint i = 0; i <= number; i++) {
                if (i <= 1)
                    result = i;
                else {
                    result = a + b;
                    a = b;
                    b = result;
                }
            }
            return result;
        }
        #endregion

        #region FACTORIALS
        // first approach
        static long Factorial(long number) {
            return number switch {
                < 2 => 1,
                _ => number * Factorial(number - 1)
            };
        }

        // final 
        static BigInteger Factorial(uint number) {
            return number switch {
                < 2 => 1,
                _ => number * Factorial(number - 1)
            };
        }
        #endregion


        static string Friendly(BigInteger number) {
            var s = number.ToString();
            return s.Length switch {
                <= 32 => s,
                _ => $"{s[0..10]}...{s[^10..]} | LEN: {s.Length}"
            };
        }
    }
}
