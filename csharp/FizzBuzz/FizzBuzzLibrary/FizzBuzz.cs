namespace FizzBuzz;

public interface IFizzBuzz
{
    string Convert(int number);
}

public class FizzBuzz : IFizzBuzz
{
    //Now this class only extracts FizzBuzz
    public string Convert(int number)
    {
        if (number % 15 == 0)
        {
            return "FizzBuzz";
        }

        if (number % 5 == 0)
        {
            return "Buzz";
        }

        if (number % 3 == 0)
        {
            return "Fizz";
        }

        return number.ToString();
    }
}