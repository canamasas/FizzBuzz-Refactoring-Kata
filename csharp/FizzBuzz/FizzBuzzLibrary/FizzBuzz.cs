namespace FizzBuzz;

public class PrintFizzBuzz
{
    private FizzBuzz _fizzBuzz;

    public PrintFizzBuzz(FizzBuzz fizzBuzz)
    {
        _fizzBuzz = fizzBuzz;
    }

    public void Print()
    {
        for (int i = 1; i < 101; i++)
        {
            Console.WriteLine(_fizzBuzz.Convert(i));
        }
    }
}

public class FizzBuzz
{
    private readonly PrintFizzBuzz _printFizzBuzz;

    public FizzBuzz()
    {
        _printFizzBuzz = new PrintFizzBuzz(this);
    }

    public PrintFizzBuzz PrintFizzBuzz
    {
        get { return _printFizzBuzz; }
    }

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