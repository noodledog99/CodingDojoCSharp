namespace CodingDojo.Lib
{
    public class SumSquareDifference : ISumSquareDifference
    {
        public int SquaresOfSum(int number)
        {
            throw new System.NotImplementedException();
        }

        public int SumOfSquares(int number)
        {
            throw new System.NotImplementedException();
        }
    }

    interface ISumSquareDifference
    {
        int SumOfSquares(int number);
        int SquaresOfSum(int number);
    }
}