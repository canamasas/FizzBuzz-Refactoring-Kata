using FizzBuzz;
using FizzBuzzProgram;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzzTests
{
  public class PrintFizzBuzzWhizzBangTests
  {
    [Fact]
    public void Stops_When_Returns_FizzBuzzWhizzBang()
    {
      //Probably this is redundant
      //Is it worth checking that it is called with the different 100 numbers? -> that is what the function is doing...

      var fizzBuzz = new Mock<IFizzBuzz>();
      var console = new Mock<IConsole>();
      var printer = new PrintFizzBuzzWhizzBang(fizzBuzz.Object, console.Object);

      fizzBuzz.Setup(f => f.Convert(It.IsAny<int>())).Returns("FizzBuzzWhizzBang");

      printer.Print();

      fizzBuzz.Verify(f => f.Convert(It.IsAny<int>()), Times.Exactly(1));
    }

    [Fact]
    public void Print_Called_Same_Times_As_Convert()
    {
      var fizzBuzz = new Mock<IFizzBuzz>();
      var console = new Mock<IConsole>();
      var printer = new PrintFizzBuzzWhizzBang(fizzBuzz.Object, console.Object);

      fizzBuzz.SetupSequence(f => f.Convert(It.IsAny<int>()))
          .Returns("1")
          .Returns("1")
          .Returns("1")
          .Returns("1")
          .Returns("1")
          .Returns("1")
          .Returns("1")
          .Returns("1")
          .Returns("1")
          .Returns("FizzBuzzWhizzBang")
          .Returns("FizzBuzzWhizzBang"); //THIS last one is not called
      int convertCalled = 10;

      int writeLineCalled = 0;
      console.Setup(f => f.WriteLine(It.IsAny<string>())).Callback(() => writeLineCalled++);

      printer.Print();

      Assert.Equal(convertCalled, writeLineCalled);
    }
  }
}
