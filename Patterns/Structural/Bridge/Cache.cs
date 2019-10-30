using System;

namespace Patterns.Structural.Bridge
{
  internal class Cache : IPersistence
  {
    private readonly IDataSource _dataSource;
    private readonly IDataSource _fallbackDataSource;

    public Cache(
      in IDataSource dataSource,
      in IDataSource fallbackDataSource)
    {
      _dataSource = dataSource ?? throw new ArgumentNullException(nameof(dataSource));
      _fallbackDataSource = fallbackDataSource ?? throw new ArgumentNullException(nameof(fallbackDataSource));
    }

    public void Write(in string data)
    {
      _dataSource.Write(data);
      _fallbackDataSource.Write(data);
    }
  }
}
