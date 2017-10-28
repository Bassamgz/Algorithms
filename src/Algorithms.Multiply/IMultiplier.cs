using System.Numerics;

namespace Algorithms.Multiply
{
    /// <summary>
    /// Standardize the multiplication algorithms to implement specific  function
    /// </summary>
    public interface IMultiplier
    {
        /// <summary>
        /// Perform multiply operation
        /// </summary>
        /// <param name="first">First number</param>
        /// <param name="second">Second number</param>
        /// <returns>Result of multiplication</returns>
        BigInteger Multiply(BigInteger first, BigInteger second);
    }
}
