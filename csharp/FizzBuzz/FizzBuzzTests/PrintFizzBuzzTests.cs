using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using FizzBuzzProgram;
using Moq;
using Xunit;

namespace FizzBuzzTests
{
  public class PrintFizzBuzzTests
  {

    [Fact]
    public void FizzBuzz_Convert_Called_With_100_different_Numbers()
    {
      //Probably this is redundant
      //Is it worth checking that it is called with the different 100 numbers? -> that is what the function is doing...

      var fizzBuzz = new Mock<IFizzBuzz>();
      var console = new Mock<IConsole>();
      var printer = new PrintFizzBuzz(fizzBuzz.Object, console.Object);

      fizzBuzz.Setup(f => f.Convert(It.IsAny<int>())).Returns("TestingFoo");

      printer.Print();

      for (var i = 1; i < 101; i++)
      {
        fizzBuzz.Verify(f => f.Convert(i), Times.Exactly(1));
      }
    }

    [Fact]
    public void FizzBuzz_Convert_Is_Called_100_times()
    {
      //Probably this is redundant
      //Is it worth checking that it is called with the different 100 numbers? -> that is what the function is doing...

      var fizzBuzz = new Mock<IFizzBuzz>();
      var console = new Mock<IConsole>();
      var printer = new PrintFizzBuzz(fizzBuzz.Object, console.Object);

      fizzBuzz.Setup(f => f.Convert(It.IsAny<int>())).Returns("TestingFoo");

      printer.Print();

      fizzBuzz.Verify(f => f.Convert(It.IsAny<int>()), Times.Exactly(100));
    }
    [Fact]
    public void FizzBuzz_WriteLine_Is_Called_100_times()
    {
      var fizzBuzz = new Mock<IFizzBuzz>();
      var console = new Mock<IConsole>();
      var printer = new PrintFizzBuzz(fizzBuzz.Object, console.Object);

      fizzBuzz.Setup(f => f.Convert(It.IsAny<int>())).Returns("TestingFoo");

      printer.Print();

      console.Verify(f => f.WriteLine("TestingFoo"), Times.Exactly(100));
    }
  }
}
