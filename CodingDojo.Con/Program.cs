using System;
using CodingDojo.Lib;

namespace CodingDojo.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            var func = new PrimeHelper();
            System.Console.WriteLine(func.GetPrime(10001));
        }
    }
}
