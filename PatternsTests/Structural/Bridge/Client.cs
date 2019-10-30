using NUnit.Framework;

using Patterns.Structural.Bridge;

namespace PatternsTests.Structural.Bridge
{
  [TestFixture]
  internal class Client
  {
    [Test]
    public void DatabaseTest()
    {
      IDataSource msSql = new MsSql();
      IPersistence database = new Database(msSql);

      database.Write("data");
    }

    [Test]
    public void CacheTest()
    {
      IDataSource couchbase = new Couchbase();
      IDataSource msSql = new MsSql();
      IPersistence cache = new Cache(couchbase, msSql);

      cache.Write("data");
    }
  }
}
