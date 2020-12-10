using System;
using System.Linq;
using System.Numerics;

namespace CodingDojo.Lib
{
    public class PowerDigitSum : IPowerDigitSum
    {
        public BigInteger PowerNumber(int number)
        {
            return BigInteger.Pow(2, number);
        }

        public int SumOfDigit(BigInteger number)
        {
            return number.ToString().Select(c => int.Parse(c.ToString())).Sum();
        }
    }

    public interface IPowerDigitSum
    {
        BigInteger PowerNumber(int number);
        int SumOfDigit(BigInteger number);
    }
}