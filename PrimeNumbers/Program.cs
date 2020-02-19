using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            Prime p1 = new Prime(num);

            int primeNum = Prime.GetPrime(num);
            Console.WriteLine(primeNum);
        }
    }
}
