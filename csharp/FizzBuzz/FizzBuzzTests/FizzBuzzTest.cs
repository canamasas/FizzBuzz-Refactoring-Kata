
using Xunit;

namespace FizzBuzzTests;

public class FizzBuzzTest
{
  [Fact]
  public void NonMultipleOfThreeOrFiveArePreserved()
  {
    Assert.Equal("1", new FizzBuzz.FizzBuzz().Convert(1));
    Assert.Equal("4", new FizzBuzz.FizzBuzz().Convert(4));
  }
  [Fact]
  public void MultipleOfThreeAreFizz()
  {
    Assert.Equal("Fizz", new FizzBuzz.FizzBuzz().Convert(3));
    Assert.Equal("Fizz", new FizzBuzz.FizzBuzz().Convert(6));
  }

  [Fact]
  public void MultipleOfFiveAreBuzz()
  {
    Assert.Equal("Buzz", new FizzBuzz.FizzBuzz().Convert(5));
    Assert.Equal("Buzz", new FizzBuzz.FizzBuzz().Convert(10));
  }

  [Fact]
  public void MultipleOfThreeAndFiveAreFizzBuzz()
  {
    Assert.Equal("FizzBuzz", new FizzBuzz.FizzBuzz().Convert(15));
    Assert.Equal("FizzBuzz", new FizzBuzz.FizzBuzz().Convert(30));
  }

}