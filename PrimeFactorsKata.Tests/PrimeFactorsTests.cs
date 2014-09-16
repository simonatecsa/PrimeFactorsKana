using System.Collections.Generic;
using NUnit.Framework;

namespace PrimeFactorsKata.Tests
{
    [TestFixture]
    public class PrimeFactorsTests
    {
        [Test]
        public void PrimeFactorsFor_1()
        {
            Assert.AreEqual(new List<int>(), PrimeFactors.Generate(1));
        }

        [Test]
        public void PrimeFactorsFor_2()
        {
            Assert.AreEqual(new List<int> { 2 }, PrimeFactors.Generate(2));
        }

        [Test]
        public void PrimeFactorsFor_4()
        {
            Assert.AreEqual(new List<int>{2,2}, PrimeFactors.Generate(4));
        }

        [Test]
        public void PrimeFactorsFor_18()
        {
            Assert.AreEqual(new List<int> { 2, 3, 3 }, PrimeFactors.Generate(18));
        }

        [Test]
        public void PrimeFactorsFor_13()
        {
            Assert.AreEqual(new List<int>{13}, PrimeFactors.Generate(13));
        }
    }
}
