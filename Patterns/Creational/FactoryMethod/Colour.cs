namespace Patterns.Creational.FactoryMethod
{
  internal class Colour
  {
    public static Colour FromRgb(byte red, byte green, byte blue)
    {
      return new Colour(red, green, blue);
    }

    public static Colour FromName(string name)
    {
      return new Colour(0, 0, 0);
    }

    private Colour(byte red, byte green, byte blue)
    {
    }
  }
}
