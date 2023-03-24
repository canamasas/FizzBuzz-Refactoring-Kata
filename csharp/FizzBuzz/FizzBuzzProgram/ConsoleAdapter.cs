namespace FizzBuzzProgram;

public class ConsoleAdapter : IConsole
{
    public void WriteLine(string convert)
    {
        Console.WriteLine(convert);
    }
}