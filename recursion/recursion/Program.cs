using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            Countdown(i);

            int val = 5;
            Console.WriteLine("Recursion: " + Factorial(val));

            //vediamo come ottenere lo stesso risultato con i loops
            Console.WriteLine("While: " + FractionalWhile(val));

            //altro esempio
            int[] arr = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Array values: { 1, 2, 3, 4 }");

            int res = SumWithRecursive(arr);
            Console.WriteLine("Recursion: " + res);

            int result = SumWithLoop(arr);
            Console.WriteLine("Loop: " + result);
        }

        private static int FractionalWhile(int v)
        {
            int result = 1;

            while (true)
            {
                if (v == 1)
                {
                    return result;
                }

                result *= v;//forma contratta di "result = result * v"
                v--;
            }
        }

        private static int Factorial(int v)
        {
            if (v == 1)
            {
                return 1;
            }

            return v * Factorial(v - 1);
        }

        private static void Countdown(int i)
        {
            Console.WriteLine(i);
            Thread.Sleep(10);

            //base case
            if (i == 0)
            {
                return;
            }
            //recursive case
            Countdown(i - 1);
        }

        private static int SumWithRecursive(int[] arr)
        {
            int result = 0;
            //base case:
            //array con 0 o un elemento
            //recursive:
            //scalare l'array sempre più vicina al caso base
            if (arr.Length == 0)
            {
                return result;
            }

            return arr[0] + SumWithRecursive(arr[1..]);
        }

        private static int SumWithLoop(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }

            return total;
        }
    }
}
