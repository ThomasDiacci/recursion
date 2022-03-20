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
    }
}
