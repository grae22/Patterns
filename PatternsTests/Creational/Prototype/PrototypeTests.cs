using NUnit.Framework;
using Patterns.Creational.Prototype;

namespace PatternsTests.Creational.Prototype
{
  [TestFixture]
  public class PrototypeTests
  {
    [Test]
    public void Clone_GivenRgbImage_ShouldReturnNewInstanceWithSameBackgroundColour()
    {
      // Arrange.
      Image initialImage = new RgbImage
      {
        BackgroundColour = "red"
      };

      // Act.
      var newImage = initialImage.Clone();

      // Assert.
      Assert.NotNull(newImage);
      Assert.AreNotSame(initialImage, newImage);
      Assert.IsInstanceOf<RgbImage>(newImage);
      Assert.AreEqual(initialImage.BackgroundColour, newImage.BackgroundColour);
    }

    [Test]
    public void Clone_GivenMonochromeImage_ShouldReturnNewInstanceWithSameBackgroundColour()
    {
      // Arrange.
      Image initialImage = new MonochromeImage
      {
        BackgroundColour = "black"
      };

      // Act.
      var newImage = initialImage.Clone();

      // Assert.
      Assert.NotNull(newImage);
      Assert.AreNotSame(initialImage, newImage);
      Assert.IsInstanceOf<MonochromeImage>(newImage);
      Assert.AreEqual(initialImage.BackgroundColour, newImage.BackgroundColour);
    }
  }
}
