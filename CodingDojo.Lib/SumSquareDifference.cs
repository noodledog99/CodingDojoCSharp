using System;
using System.Linq;

namespace CodingDojo.Lib
{
    public class SumSquareDifference : ISumSquareDifference
    {
        public double SquaresOfSum(int number)
        {
            var sum = Enumerable.Range(1, number).Sum(it => Math.Pow(it, 2));
            return sum;
        }

        public double SumOfSquares(int number)
        {
            var sum = Math.Pow(Enumerable.Range(1, number).Sum(it => it), 2);
            return sum;
        }
    }

    interface ISumSquareDifference
    {
        double SumOfSquares(int number);
        double SquaresOfSum(int number);
    }
}