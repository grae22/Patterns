using System;

using NUnit.Framework;

using Patterns.Structural.Proxy;

namespace PatternsTests.Structural.Proxy
{
  [TestFixture]
  public class Client
  {
    [Test]
    public void Test()
    {
      IDataAccess dataAccess = new DataAccess();

      dataAccess = new DataAccessMetrics(dataAccess);

      dataAccess.WriteData("data");
    }
  }
}
