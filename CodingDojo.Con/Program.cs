using System;
using CodingDojo.Lib;

namespace CodingDojo.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            // var func = new PrimeHelper();
            // System.Console.WriteLine(func.GetPrime(10001));

            var func = new SumSquareDifference();
            System.Console.WriteLine(func.SquaresOfSum(100));
            System.Console.WriteLine(func.SumOfSquares(100));
        }
    }
}
