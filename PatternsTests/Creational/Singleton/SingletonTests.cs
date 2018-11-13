using System;
using NSubstitute;
using NUnit.Framework;
using Patterns.Creational.Singleton;

namespace PatternsTests.Creational.Singleton
{
  [TestFixture]
  public class SingletonTests
  {
    private class TestLogger : ILogger
    {
      public void Log(string message)
      {
      }
    }

    [Test]
    public void InstanceProperty_GivenFirstUse_ShouldNotBeNull()
    {
      // Arrange.
      // Act.
      // Assert.
      Assert.NotNull(Logger.Instance);
    }

    [Test]
    public void Constructor_GivenSubclass_ShouldAllowOwnInstance()
    {
      // Arrange.
      var newLogger = new TestLogger();

      // Act.
      Logger.SetLogger(newLogger);

      // Assert.
      Assert.IsInstanceOf<TestLogger>(Logger.Instance);
    }
    
    [Test]
    public void SetLogger_GivenLoggerAlreadyUsed_ShouldRaiseException()
    {
      // Arrange.
      Logger.Instance.Log(string.Empty);

      // Act.
      // Assert.
      Assert
        .Throws<NotSupportedException>(() =>
          Logger.SetLogger(Substitute.For<ILogger>()));
    }
  }
}
