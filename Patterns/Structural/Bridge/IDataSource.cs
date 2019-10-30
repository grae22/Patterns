namespace Patterns.Structural.Bridge
{
  internal interface IDataSource
  {
    void Open();
    void Write(string data);
    void Close();
  }
}
