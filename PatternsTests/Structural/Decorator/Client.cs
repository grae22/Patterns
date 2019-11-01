using NUnit.Framework;

using Patterns.Structural.Decorator;

namespace PatternsTests.Structural.Decorator
{
  [TestFixture]
  public class Client
  {
    [Test]
    public void Test()
    {
      const bool isPasswordRedactionEnabled = true;

      ILogger logger = new PlainTextLogger();

      if (isPasswordRedactionEnabled)
      {
        logger = new PasswordRedactingLogger(logger);
      }

      logger.Log("message");
    }
  }
}
