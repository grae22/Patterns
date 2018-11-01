using NUnit.Framework;
using Patterns.Creational.ObjectPool;

namespace PatternsTests.Creational.ObjectPool
{
  [TestFixture]
  public class ThreadPoolTests
  {
    [Test]
    public void AcquireThread_GivenAvailableThreads_ShouldReturnThread()
    {
      // Arrange.
      var testObject = new ThreadPool(maxThreadCount: 1);

      // Act.
      Thread thread = testObject.AcquireThread();

      // Assert.
      Assert.NotNull(thread);
    }

    [Test]
    public void AcquireThread_GivenNoAvailableThreads_ShouldReturnNull()
    {
      // Arrange.
      var testObject = new ThreadPool(maxThreadCount: 1);

      testObject.AcquireThread();

      // Act.
      Thread thread = testObject.AcquireThread();

      // Assert.
      Assert.Null(thread);
    }
    
    [Test]
    public void ReleaseThread_GivenNoAvailableThreads_ShouldMakeReleasedThreadAvailableForAcquire()
    {
      // Arrange.
      var testObject = new ThreadPool(maxThreadCount: 3);

      var acquiredThread = testObject.AcquireThread();

      testObject.AcquireThread();
      testObject.AcquireThread();

      Assert.Null(testObject.AcquireThread());

      // Act.
      testObject.ReleaseThread(acquiredThread);

      Thread thread = testObject.AcquireThread();

      // Assert.
      Assert.NotNull(thread);
    }
  }
}
