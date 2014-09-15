using System;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToFindPrimeFactors = ReadNumberToFindPrimeFactors();

            List<int> primeFactors = PrimeFactors.Generate(numberToFindPrimeFactors);

            PrintPrimeFactors(numberToFindPrimeFactors, primeFactors);

            Console.ReadKey();
        }

        private static int ReadNumberToFindPrimeFactors()
        {
            Console.WriteLine("Please specify the number you want to find the prime factors: ");
            int numberToFindPrimeFactors = Int32.Parse(Console.ReadLine());
            return numberToFindPrimeFactors;
        }

        private static void PrintPrimeFactors(int numberToFindPrimeFactors, List<int> primeFactors)
        {
            Console.WriteLine("The prime factors of the number {0} are:", numberToFindPrimeFactors);
            foreach (var primeFactor in primeFactors)
            {
                Console.Write(primeFactor + " ");
            }
        }
    }
}
