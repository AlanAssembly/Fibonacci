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
                Console.Write("Number = ? ");
                _ = uint.TryParse(Console.ReadLine(), out uint x);
                if (x > 0 && x <= 1000) {
                    //Console.WriteLine("\nFibonacci_Recursive({0}) = {1}", x, Fibonacci(x));
                    Console.WriteLine("Factorial: {0}", Factorial(x));
                } else {
                    Console.WriteLine("Bad number");
                    break;
                }
            }
        }

        static ulong Fibonacci(ulong number) {
            return number switch {
                <= 2 => 1,
                3 => 2,
                _ => Fibonacci(number - 1) + Fibonacci(number - 2)
            };
        }

        static ulong FactorialApproach(ulong number) {
            return number switch {
                < 2 => 1,
                _ => number * FactorialApproach(number - 1)
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

        #endregion
    }
}
