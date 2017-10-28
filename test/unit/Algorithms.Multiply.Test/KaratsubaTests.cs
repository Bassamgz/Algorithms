using System.Numerics;
using Xunit;

namespace Algorithms.Multiply.Tests
{
    public class KaratsubaTests
    {
        private readonly Karatsuba _ops = new Karatsuba();

        //[Theory]
        //[InlineData(0, 1, 0)]
        //[InlineData(1, 0, 0)]
        //[InlineData(1, 1, 1)]
        //[InlineData(3, 4, 12)]
        //public void Muliply_NumbersBelow10_ReturnsResults(BigInteger first, BigInteger second, BigInteger expectedResult)
        //{
        //    // Arrange

        //    // Act
        //    var actualResult = _ops.Multiply(first, second);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}

        [Fact]
        public void Muliply_Zeros_ReturnsZero()
        {
            // Arrange

            // Act
            var actualResult = _ops.Multiply(0, 0);

            // Assert
            Assert.Equal(0, actualResult);
        }

        [Fact]
        public void Muliply_ZeroAndOne_ReturnsZero()
        {
            // Arrange

            // Act
            var actualResult = _ops.Multiply(0, 1);

            // Assert
            Assert.Equal(0, actualResult);
        }

        [Fact]
        public void Muliply_OneAndZero_ReturnsZero()
        {
            // Arrange

            // Act
            var actualResult = _ops.Multiply(1, 0);

            // Assert
            Assert.Equal(0, actualResult);
        }

        [Fact]
        public void Muliply_ThreeAndFour_ReturnsResult()
        {
            // Arrange

            // Act
            var actualResult = _ops.Multiply(3, 4);

            // Assert
            Assert.Equal(12, actualResult);
        }

        [Fact]
        public void Muliply_Sample1_ReturnsResult()
        {
            // Arrange

            // Act
            var actualResult = _ops.Multiply(1234, 4321);

            // Assert
            Assert.Equal(5332114, actualResult);
        }

        [Fact]
        public void Muliply_Sample2_ReturnsResult()
        {
            // Arrange

            // Act
            var actualResult = _ops.Multiply(1234, 5678);

            // Assert
            Assert.Equal(7006652, actualResult);
        }

        [Fact]
        public void Muliply_MaxInt32_ReturnsResult()
        {
            // Arrange

            // Act
            var actualResult = _ops.Multiply(int.MaxValue, int.MaxValue);

            // Assert
            Assert.Equal(BigInteger.Pow(int.MaxValue, 2), actualResult);
        }

        [Fact]
        public void Muliply_MaxInt64_ReturnsResult()
        {
            // Arrange

            // Act
            var actualResult = _ops.Multiply(long.MaxValue, long.MaxValue);

            // Assert
            Assert.Equal(BigInteger.Pow(long.MaxValue, 2), actualResult);
        }

    }
}
