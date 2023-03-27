using FizzBuzz;
using Xunit;

namespace FizzBuzzTests;

public class FizzBuzzWhizzBangTests
{
  [Fact]
  public void NonMultipleOfThreeOrFiveArePreserved()
  {
    Assert.Equal("1", new FizzBuzzWhizzBang().Convert(1));
    Assert.Equal("4", new FizzBuzzWhizzBang().Convert(4));
  }
  [Fact]
  public void MultipleOfThreeAreFizz()
  {
    Assert.Equal("Fizz", new FizzBuzzWhizzBang().Convert(3));
    Assert.Equal("Fizz", new FizzBuzzWhizzBang().Convert(6));
  }

  [Fact]
  public void MultipleOfFiveAreBuzz()
  {
    Assert.Equal("Buzz", new FizzBuzzWhizzBang().Convert(5));
    Assert.Equal("Buzz", new FizzBuzzWhizzBang().Convert(10));
  }

  [Fact]
  public void MultipleOfThreeAndFiveAreFizzBuzz()
  {
    Assert.Equal("FizzBuzz", new FizzBuzzWhizzBang().Convert(15));
    Assert.Equal("FizzBuzz", new FizzBuzzWhizzBang().Convert(30));
  }

  [Fact]
  public void MultipleOfSevenAreWhizz()
  {
    Assert.Equal("Whizz", new FizzBuzzWhizzBang().Convert(7));
    Assert.Equal("Whizz", new FizzBuzzWhizzBang().Convert(14));
  }

  [Fact]
  public void MultipleOfElevenAreBang()
  {
    Assert.Equal("Bang", new FizzBuzzWhizzBang().Convert(11));
    Assert.Equal("Bang", new FizzBuzzWhizzBang().Convert(11 * 2));
  }

  [Fact]
  public void MultipleOfSevenAndElevenAreWhizzBang()
  {
    Assert.Equal("WhizzBang", new FizzBuzzWhizzBang().Convert(77));
    Assert.Equal("WhizzBang", new FizzBuzzWhizzBang().Convert(77 * 2));
    Assert.Equal("WhizzBang", new FizzBuzzWhizzBang().Convert(5929));
  }

  [Fact]
  public void MultipleOfThreeAndSevenIsFizzWhizz()
  {
    Assert.Equal("FizzWhizz", new FizzBuzzWhizzBang().Convert(3 * 7));
    Assert.Equal("FizzWhizz", new FizzBuzzWhizzBang().Convert(3 * 7 * 2));
    Assert.Equal("FizzWhizz", new FizzBuzzWhizzBang().Convert(3 * 7 * 3 * 7));
  }

  [Fact]
  public void MultipleOfThreeAndElevenIsFizzBang()
  {
    Assert.Equal("FizzBang", new FizzBuzzWhizzBang().Convert(3 * 11));
    Assert.Equal("FizzBang", new FizzBuzzWhizzBang().Convert(3 * 11 * 2));
    Assert.Equal("FizzBang", new FizzBuzzWhizzBang().Convert(3 * 11 * 3 * 11));
  }

  [Fact]
  public void MultipleOfFiveAndSevenIsBuzzWhizz()
  {
    Assert.Equal("BuzzWhizz", new FizzBuzzWhizzBang().Convert(5 * 7));
    Assert.Equal("BuzzWhizz", new FizzBuzzWhizzBang().Convert(5 * 7 * 2));
    Assert.Equal("BuzzWhizz", new FizzBuzzWhizzBang().Convert(5 * 7 * 5 * 7));
  }

  [Fact]
  public void MultipleOfFiveAndElevenIsBuzzBang()
  {
    Assert.Equal("BuzzBang", new FizzBuzzWhizzBang().Convert(5 * 11));
    Assert.Equal("BuzzBang", new FizzBuzzWhizzBang().Convert(5 * 11 * 2));
    Assert.Equal("BuzzBang", new FizzBuzzWhizzBang().Convert(5 * 11 * 5 * 11));
  }

  [Fact]
  public void MultipleOfSevenAndElevenIsWhizzBang()
  {
    Assert.Equal("WhizzBang", new FizzBuzzWhizzBang().Convert(7 * 11));
    Assert.Equal("WhizzBang", new FizzBuzzWhizzBang().Convert(7 * 11 * 7 * 11));
  }

  [Fact]
  public void MultipleOfFifteenAndSevenIsFizzBuzzWhizz()
  {
    Assert.Equal("FizzBuzzWhizz", new FizzBuzzWhizzBang().Convert(15 * 7));
    Assert.Equal("FizzBuzzWhizz", new FizzBuzzWhizzBang().Convert(15 * 7 * 2));
    Assert.Equal("FizzBuzzWhizz", new FizzBuzzWhizzBang().Convert(15 * 7 * 15 * 7));
  }

  [Fact]
  public void MultipleOfFifteenAndElevenIsFizzBuzzBang()
  {
    Assert.Equal("FizzBuzzBang", new FizzBuzzWhizzBang().Convert(15 * 11));
    Assert.Equal("FizzBuzzBang", new FizzBuzzWhizzBang().Convert(15 * 11 * 15 * 11));
  }

  [Fact]
  public void MultipleOfThreeAndFiveAndSevenAndElevenAreFizzBuzzWhizzBang()
  {
    Assert.Equal("FizzBuzzWhizzBang", new FizzBuzzWhizzBang().Convert(3 * 5 * 7 * 11));
    Assert.Equal("FizzBuzzWhizzBang", new FizzBuzzWhizzBang().Convert(3 * 5 * 7 * 11 * 2));

  }
}