using System;
using Xunit;
using Lab4._3PrimeNumbers;

namespace Lab4._3PrimeNumbers
{
    public class UnitTest1
    {
    

       [Theory]
       [InlineData(1, 2)]
       [InlineData(2, 3)]
       [InlineData(3, 5)]
       [InlineData(4, 7)]
       [InlineData(5, 11)]
       [InlineData(6, 13)]
       [InlineData(7, 17)]
       [InlineData(8, 19)]
       [InlineData(9, 23)]
       [InlineData(10, 29)]
        public void IsPrime(int a, int expected)
        {
            int result = Prime.GetPrime(a);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(3)]
        [InlineData(7)]
        public void Test2(int a)
        {
            bool result = PrimeNumbers.IsPrime(a);

            Assert.True(result);
        }
        
    }
}
