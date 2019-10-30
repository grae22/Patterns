namespace Patterns.Structural.Bridge
{
  internal interface IPersistence
  {
    void Write(in string data);
  }
}
