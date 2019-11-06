namespace Patterns.Structural.Flyweight
{
  internal class ModelGraphicsInstance
  {
    private readonly IModelGraphics _modelGraphics;
    private readonly Position _position;
    private readonly string _id;

    public ModelGraphicsInstance(
      in IModelGraphics modelGraphics,
      in Position position,
      in string id)
    {
      _modelGraphics = modelGraphics;
      _position = position;
      _id = id;
    }
  }
}
