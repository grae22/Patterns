using NUnit.Framework;

using Patterns.Structural.Facade;

namespace PatternsTests.Structural.Facade
{
  [TestFixture]
  public class Client
  {
    [Test]
    public void Test()
    {
      var carBody = CarBuilder.Build();
    }
  }
}
