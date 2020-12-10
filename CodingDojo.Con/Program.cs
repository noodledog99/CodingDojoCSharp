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

            // var func = new SumSquareDifference();
            // System.Console.WriteLine(func.SquaresOfSum(100));
            // System.Console.WriteLine(func.SumOfSquares(100));

            var func = new PowerDigitSum();
            System.Console.WriteLine(func.SumOfDigit((func.PowerNumber(1000))));
            
            // var xx = "367777";
            // var x = xx[1];
            // System.Console.WriteLine(x);
            // System.Console.WriteLine(Convert.ToInt32(x)); // ascii
            // System.Console.WriteLine(int.Parse(x.ToString())); 

        }
    }
}
