using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public class PrimeFactors
    {
        public static List<int> Generate(int numberToFindPrimeFactors)
        {
            List<int> primeFactors = new List<int>();
            int factor = 2;
            while (numberToFindPrimeFactors > 1)
            {
                while (numberToFindPrimeFactors % factor == 0)
                {
                    numberToFindPrimeFactors = numberToFindPrimeFactors/factor;
                    primeFactors.Add(factor);
                }
                factor += 1;
            }
            return primeFactors;
        } 
    }
}
