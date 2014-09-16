using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public class PrimeFactors
    {
        // name: parameter name is unnecessarily long. n is a perfect name here :)
        // see Clean Code on names and scope (pg. 22): 
        // The length of a name should correspond to the size of its scope
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
