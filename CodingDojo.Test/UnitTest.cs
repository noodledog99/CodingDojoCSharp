using System;
using CodingDojo.Lib;
using Xunit;

namespace CodingDojo.Test
{
    public class UnitTest
    {
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        public void TestIsPrime(int number)
        {
            var sut = new PrimeHelper();
            var result = sut.IsPrime(number);
            Assert.True(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void TestIsNotPrime(int number)
        {
            var sut = new PrimeHelper();
            var result = sut.IsPrime(number);
            Assert.False(result);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        public void TestGetPrime(int index, int expected)
        {
            var sut = new PrimeHelper();
            var result = sut.GetPrime(index);
            Assert.Equal(expected, result);
        }
    }
}
