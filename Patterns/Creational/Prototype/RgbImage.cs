namespace Patterns.Creational.Prototype
{
  internal class RgbImage : Image
  {
    public override Image Clone()
    {
      return new RgbImage
      {
        BackgroundColour = BackgroundColour
      };
    }
  }
}
