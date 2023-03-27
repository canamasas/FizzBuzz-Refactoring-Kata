namespace FizzBuzz;

public class FizzBuzzWhizzBang : IFizzBuzz
{
    public string Convert(int number)
    {
        if (number % (15 * 7 * 11) == 0)
        {
            return "FizzBuzzWhizzBang";
        }

        if (number % (15 * 11) == 0)
        {
            return "FizzBuzzBang";
        }

        if (number % (15 * 7) == 0)
        {
            return "FizzBuzzWhizz";
        }

        if (number % (7 * 11) == 0)
        {
            return "WhizzBang";
        }

        if (number % (5 * 11) == 0)
        {
            return "BuzzBang";
        }

        if (number % (5 * 7) == 0)
        {
            return "BuzzWhizz";
        }

        if (number % (3 * 11) == 0)
        {
            return "FizzBang";
        }

        if (number % (3*7) == 0)
        {
            return "FizzWhizz";
        }

        if (number % 15 == 0)
        {
            return "FizzBuzz";
        }

        if (number % 11 == 0)
        {
            return "Bang";
        }

        if (number % 7 == 0)
        {
            return "Whizz";
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