using System;
using System.Numerics;
/*
50  => 12586269025,
*/
namespace Fibonacci
{
    class Program
    {
        static void Main() {
            Console.WriteLine("Fibionacci Approach");
            while (true) {
                Console.Write("\nNumber = ? ");
                _ = uint.TryParse(Console.ReadLine(), out uint x);
                //if (x > 0 && x <= 1000) {
                    Console.WriteLine("\nFibonacci_Recursive({0}) = {1}", x, FibonacciIterative(x));
                    //Console.WriteLine("Factorial: {0}", Factorial(x));
                //} else {
                //    Console.WriteLine("Bad number");
                //    break;
                //}
            }
        }

        static ulong FibonacciApproach(uint number) {
            return number switch {
                <= 2 => 1,
                3 => 2,
                _ => FibonacciApproach(number - 1) + FibonacciApproach(number - 2)
            };
        }

        static ulong FactorialApproach(ulong number) {
            return number switch {
                < 2 => 1,
                _ => number * FactorialApproach(number - 1)
            };
        }

        static BigInteger Fibonacci(uint number) {
            return number switch {
                <= 2 => 1,
                3 => 2,
                _ => Fibonacci(number - 1) + Fibonacci(number - 2)
            };
        }

        static BigInteger Factorial(uint number) {
            return number switch {
                < 2 => 1,
                _ => number * Factorial(number - 1)
            };
        }

        #region Experiments

        public static int FindMaxValue() {// returns 20
            int res = 2;
            long fact = 2;
            while (true) {
                // when fact crosses its size,
                // it gives negative value
                if (fact < 0)
                    break;
                res++;
                fact *= res;
            }
            return res - 1;
        }
        // fnciona hasta 46
        public static int FibonacciIterative32(uint number) {
            int a = 0, b = 1, result = 0;
            for (int i = 0; i <= number; i++) {
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

        // funciona hasta 92
        public static long FibonacciIterativeLong(uint number) {
            long a = 0, b = 1, result = 0;
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
        // funciona hasta 93
        public static ulong FibonacciIterativeUlong(uint number) {
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

        // funciona hasta ?
        public static BigInteger FibonacciIterative(uint number) {
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
    }
}
