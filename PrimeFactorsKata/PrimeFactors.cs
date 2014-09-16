using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public class PrimeFactors
    {
        public static List<int> Generate(int n)
        {
            List<int> primeFactors = new List<int>();
            int factor = 2;
            while (n > 1)
            {
                while (n % factor == 0)
                {
                    n = n/factor;
                    primeFactors.Add(factor);
                }
                factor += 1;
            }
            return primeFactors;
        } 
    }
}
