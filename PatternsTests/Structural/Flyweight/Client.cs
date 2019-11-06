using NSubstitute;

using NUnit.Framework;

using Patterns.Structural.Flyweight;

namespace PatternsTests.Structural.Flyweight
{
  [TestFixture]
  public class Client
  {
    [Test]
    public void Test()
    {
      var modelGraphicsFactory = new ModelGraphicsFactory();

      var position = new Position();

      var modelGraphicsInstance = modelGraphicsFactory.CreateInstance(
        "texture1",
        "shader1",
        position,
        "123");
    }
  }
}
