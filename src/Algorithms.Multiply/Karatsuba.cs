using System;
using System.Numerics;

namespace Algorithms.Multiply
{
    /// <inheritdoc />
    /// <summary>
    /// Perform multiply operation using Karatsuba algorithm
    /// </summary>
    public class Karatsuba : IMultiplier
    {
        public BigInteger Multiply(BigInteger first, BigInteger second)
        {
            if (first < 10 || second < 10)
            {
                return first * second;
            }

            var maxLength = Math.Max(first.ToString().Length, second.ToString().Length);
            var powerM = maxLength % 2 == 0 ? maxLength / 2 : (maxLength + 1) / 2;

            BigInteger firstHigh, firstLow, secondHigh, secondLow;
            firstHigh = BigInteger.Divide(first, BigInteger.Pow(10, powerM));
            firstLow = first % BigInteger.Pow(10, powerM);

            secondHigh = BigInteger.Divide(second, BigInteger.Pow(10, powerM));
            secondLow = second % BigInteger.Pow(10, powerM);

            var high = Multiply(firstHigh, secondHigh);
            var low = Multiply(firstLow, secondLow);
            var comb = Multiply(firstHigh + firstLow, secondHigh + secondLow) - high - low;

            return (high * BigInteger.Pow(10, 2 * powerM)) + (comb * BigInteger.Pow(10, powerM)) + low;
        }
    }
}