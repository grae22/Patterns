using System;

namespace Patterns.Structural.Bridge
{
  internal class Database : IPersistence
  {
    private readonly IDataSource _dataSource;

    public Database(in IDataSource dataSource)
    {
      _dataSource = dataSource ?? throw new ArgumentNullException(nameof(dataSource));
    }

    public void Write(in string data)
    {
      _dataSource.Open();
      _dataSource.Write(data);
      _dataSource.Close();
    }
  }
}
