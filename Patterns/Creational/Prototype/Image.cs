namespace Patterns.Creational.Prototype
{
  internal abstract class Image
  {
    public string BackgroundColour { get; set; }

    public abstract Image Clone();
  }
}
