using System;
using Xunit;
using DanDev486.CsharpSamplePackage;

namespace DanDev486.CsharpSamplePackageTest
{
    public class SampleMathTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 1)]
        [InlineData(1, -1)]
        public void GivenValidInputShouldSumWithSuccess(int a, int b)
        {
            var expected = a + b;
            var actual = SampleMath.Sum(a, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 1)]
        [InlineData(1, -1)]
        public void GivenValidInputShouldSubWithSuccess(int a, int b)
        {
            var expected = a - b;
            var actual = SampleMath.Sub(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
