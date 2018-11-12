namespace Patterns.Creational.Prototype
{
  internal class MonochromeImage : Image
  {
    public override Image Clone()
    {
      return new MonochromeImage
      {
        BackgroundColour = BackgroundColour
      };
    }
  }
}
