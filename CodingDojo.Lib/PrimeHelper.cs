using System;

namespace CodingDojo.Lib
{
    public class PrimeHelper : IPrimeHelper
    {
        public bool IsPrime(int number)
        {
            throw new NotImplementedException();
        }
        
        public int GetPrime(int index)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPrimeHelper
    {
        bool IsPrime(int number);
        int GetPrime(int index);
    }
}
