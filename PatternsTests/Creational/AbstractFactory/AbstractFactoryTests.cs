using NUnit.Framework;

namespace Patterns.Creational.AbstractFactory.Tests
{
  [TestFixture]
  public class AbstractFactoryTests
  { 
    [Test]
    public void CreateLogger_GivenFileSystem_ShouldCreateFileLogger()
    {
      // Arrange.
      ILoggerFactory factory = new FileSystemFactory();

      // Act.
      ILogger logger = factory.CreateLogger();

      // Assert.
      Assert.IsInstanceOf<FileLogger>(logger);
      Assert.IsNotInstanceOf<ConsoleLogger>(logger);
    }

    [Test]
    public void CreateLogger_GivenConsoleSystem_ShouldCreateConsoleLogger()
    {
      // Arrange.
      ILoggerFactory factory = new ConsoleSystemFactory();

      // Act.
      ILogger logger = factory.CreateLogger();

      // Assert.
      Assert.IsInstanceOf<ConsoleLogger>(logger);
      Assert.IsNotInstanceOf<FileLogger>(logger);
    }
  }
}
