using System;
using System.Numerics;
using Algorithms.Multiply;

namespace Algorithms.App
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                RunKaratsuba();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception at:{0}", ex.Message));
            }
        }

        private static void RunKaratsuba()
        {
            Console.WriteLine("Welcome to Karatsuba!");
            Console.WriteLine("Enter first number:");
            var firstInput = Console.ReadLine();

            if (string.IsNullOrEmpty(firstInput.Trim()) ||
                !BigInteger.TryParse(firstInput, out var firstNumber))
            {
                throw new ArgumentException("Not a valid number");
            }

            Console.WriteLine("Enter second number:");
            var secondInput = Console.ReadLine();

            if (string.IsNullOrEmpty(secondInput.Trim()) ||
                !BigInteger.TryParse(secondInput, out var secondNumber))
            {
                throw new ArgumentException("Not a valid number");
            }

            var ops = new Karatsuba();
            var result = ops.Multiply(firstNumber, secondNumber);
            Console.WriteLine(string.Format("Result is:{0}", result));
        }
    }
}
