using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public class Prime
    {
        private int x;
        public int X { get => x; set => x = value; }
        public Prime(int x)
        {
            this.x = x;
        }


        public static int GetPrime(int n)
        {
            int i = 1;
            int count = 0;

            while (count < n)
            {
                i++;
                if (isPrime(i)) { count++; }
            }
            return i;
        }

        public static bool isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) { return false; }
            }

            return true;
        }

    }
}
