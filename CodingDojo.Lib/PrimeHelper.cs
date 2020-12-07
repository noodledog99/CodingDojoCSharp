using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingDojo.Lib
{
    public class PrimeHelper : IPrimeHelper
    {
        public bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return number > 1;
        }

        public int GetPrime(int index)
        {
            var count = 0;
            for (int i = 2; ; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                    if (count == index) return i;
                }
            }
        }
    }

    public interface IPrimeHelper
    {
        bool IsPrime(int number);
        int GetPrime(int index);
    }
}
