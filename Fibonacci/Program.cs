/*
Factorial and Fibionacci Approach

POST: 


Test:
https://onlinemathtools.com/calculate-factorial

*/
using System;
using System.Numerics;

namespace Fibonacci
{
    class Program
    {
        static void Main() {
            Console.WriteLine("Factorial and Fibionacci Approach");
            while (true) {
                Console.Write("\nNumber = ? ");
                _ = uint.TryParse(Console.ReadLine(), out uint x);
                if (x == 0) {
                    break;
                }
                if (x > 0 && x <= 10000) {
                    Console.WriteLine("\nFibonacci({0}) = {1}", x, Friendly(Fibonacci(x)));
                    Console.WriteLine("Factorial: {0}", Friendly(Factorial(x)));
                    //Console.WriteLine("Factorial: {0}", Friendly(Factorial64(x)));
                    //Console.WriteLine("Factorial: {0}", Friendly(FactorialBadApproach((int)x)));
                } else {
                    Console.WriteLine("Bad number");
                    break;
                }
            }
        }

        #region FACTORIALS
        // first approach, works up to 20 !
        static ulong Factorial64(uint number) {
            return number switch {
                < 2 => 1,
                _ => number * Factorial64(number - 1)
            };
        }

        /// <summary>
        /// Factorial function
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static BigInteger Factorial(uint n) {
            if (n <= 1) {
                return 1;
            }
            BigInteger result = 1;
            for (BigInteger i = 2; i <= n; i++) {
                result *= i;
            }
            return result;
        }

        // bad approach. works up to 12 !
        static int FactorialBadApproach(int n) {
            if (n <= 1) {
                return 1;
            }
            return n * FactorialBadApproach(n - 1);
        }
        #endregion


        #region FIBONACCI
        // fatal, the performance degrades incrementally as the numbers are greater than 40, i.g. 48-> 30 s!
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

        /// <summary>
        /// Fibonacci Function
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
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

        public static int FibonacciBadApproach(int number) {
            if (number <= 2)
                return 1;
            else
                return FibonacciBadApproach(number - 1) + FibonacciBadApproach(number - 2);
        }
        #endregion


        static string Friendly(BigInteger number) {
            var s = number.ToString();
            return s.Length switch {
                <= 32 => s,
                _ => $"{s[0..10]}...{s[^10..]} | LEN: {s.Length}"
            };
        }

        /// <summary>
        /// 
        /// </summary>
        static void FactorialTest() {
            Console.WriteLine("FACTORIAL TEST");
            try {
                for (uint i = 10_000; i <= 100_000; i += 10_000) {
                    Console.WriteLine("Factorial({0}) => {1}", i, Friendly(Factorial(i)));
                }
            } catch {
                Console.WriteLine("Has stopped.");
            }
            Console.WriteLine("END");
        }

        /// <summary>
        /// 
        /// </summary>
        static void FibonacciTest() {
            Console.WriteLine("FIBONACCI TEST");
            try {
                for (uint i = 10_000; i <= 100_000; i += 10_000) {
                    Console.WriteLine("Fibonacci({0}) => {1}", i, Friendly(Fibonacci(i)));
                }
            } catch {
                Console.WriteLine("Has stopped.");
            }
            Console.WriteLine("END");
        }
    }
}
