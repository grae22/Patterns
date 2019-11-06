namespace Patterns.Structural.Flyweight
{
  internal struct Position
  {
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Position(
      double x,
      double y,
      double z)
    {
      X = x;
      Y = y;
      Z = z;
    }
  }
}
