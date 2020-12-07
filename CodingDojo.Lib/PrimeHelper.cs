using System;

namespace CodingDojo.Lib
{
    public class PrimeHelper
    {
    }

    public interface IPrimeHelper
    {
        bool IsPrime(int number);
        int GetPrime(int index);
    }
}
