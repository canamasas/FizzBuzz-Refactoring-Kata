using FizzBuzz;

namespace FizzBuzzProgram;

public interface IPrintFizzBuzz
{
  void Print();
}

public class PrintFizzBuzz : IPrintFizzBuzz
{
  //Extracted a class that its purpose is to print.
  private readonly IFizzBuzz _fizzBuzz;
  private readonly IConsole _console;

  public PrintFizzBuzz(IFizzBuzz fizzBuzz, IConsole console)
  {
    _fizzBuzz = fizzBuzz;
    _console = console;
  }

  public void Print()
  {
    for (int i = 1; i < 101; i++)
    {
      _console.WriteLine(_fizzBuzz.Convert(i));
    }
  }
}