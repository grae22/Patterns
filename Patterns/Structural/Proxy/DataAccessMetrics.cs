namespace Patterns.Structural.Proxy
{
  internal class DataAccessMetrics : IDataAccess
  {
    private readonly IDataAccess _dataAccess;

    public DataAccessMetrics(in IDataAccess dataAccess)
    {
      _dataAccess = dataAccess;
    }

    public void WriteData(in string data)
    {
      // Do some metrics logic...

      _dataAccess.WriteData(data);

      // Do some metrics logic...
    }
  }
}
