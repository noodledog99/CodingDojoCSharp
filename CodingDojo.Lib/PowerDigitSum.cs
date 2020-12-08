namespace CodingDojo.Lib
{
    public class PowerDigitSum : IPowerDigitSum
    {

    }

    public interface IPowerDigitSum
    {
        double PowerNumber(int number);
        int SumOfDigit(int number);
    }
}