namespace Patterns.Structural.Proxy
{
  internal class DataAccess : IDataAccess
  {
    public void WriteData(in string data)
    {
      // Writes some data to some data store...
    }
  }
}
