using ChanhDuongAPI.ServicesCore;
using System.Numerics;
using Xunit;

namespace ChanhDuongAPI.Tests
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(50, 12586269025)]
        public void Fibonacci_SimpleValuesShouldCalculate(int n, BigInteger expected)
        {
            BigInteger actual = Fibonacci.Calculate(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-4)]
        [InlineData(-101)]
        [InlineData(10000)]
        public void Fibonacci_SpecialValuesShouldReturnMinusOne(int n)
        {
            BigInteger expected = -1;
            BigInteger actual = Fibonacci.Calculate(n);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Fibonacci_BigValuesShouldCalculate()
        {
            BigInteger expected = BigInteger.Parse("354224848179261915075");
            BigInteger actual = Fibonacci.Calculate(100);
            Assert.Equal(expected, actual);
        }
    }
}
