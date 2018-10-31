using NUnit.Framework;
using Patterns.Creational.FactoryMethod;

namespace PatternsTests.Creational.FactoryMethod
{
  [TestFixture]
  public class ColourTests
  {
    [Test]
    public void FromRgb_GivenRgb_ShouldReturnNewInstance()
    {
      // Arrange.
      // Act.
      Colour result = Colour.FromRgb(255, 128, 64);

      // Assert.
      Assert.NotNull(result);
    }
    
    [Test]
    public void FromName_GivenName_ShouldReturnNewInstance()
    {
      // Arrange.
      // Act.
      Colour result = Colour.FromName("red");

      // Assert.
      Assert.NotNull(result);
    }
  }
}
