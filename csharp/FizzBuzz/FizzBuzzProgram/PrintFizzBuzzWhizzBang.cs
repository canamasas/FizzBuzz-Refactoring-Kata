using FizzBuzz;

namespace FizzBuzzProgram;

public class PrintFizzBuzzWhizzBang : IPrintFizzBuzz
{
  //Extracted a class that its purpose is to print.
  private readonly IFizzBuzz _fizzBuzz;
  private readonly IConsole _console;

  public PrintFizzBuzzWhizzBang(IFizzBuzz fizzBuzz, IConsole console)
  {
    _fizzBuzz = fizzBuzz;
    _console = console;
  }

  public void Print()
  {
    var i = 1;
    var convert = _fizzBuzz.Convert(i);
    while (!convert.Equals("FizzBuzzWhizzBang"))
    {
      _console.WriteLine(convert);
      i++;
      convert = _fizzBuzz.Convert(i);
    }
    _console.WriteLine(convert);
  }
}