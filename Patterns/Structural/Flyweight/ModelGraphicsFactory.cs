using System.Collections.Generic;
using System.Linq;

namespace Patterns.Structural.Flyweight
{
  internal class ModelGraphicsFactory
  {
    private List<IModelGraphics> _modelGraphics = new List<IModelGraphics>();

    public ModelGraphicsInstance CreateInstance(
      string textureName,
      string shaderName,
      Position position,
      string id)
    {
      IModelGraphics modelGraphics =
        _modelGraphics
          .FirstOrDefault(mg =>
            mg.Texture.Name == textureName &&
            mg.Shader.Name == shaderName);

      if (modelGraphics == null)
      {
        _modelGraphics.Add(
          new ModelGraphics(
            null, // Null simply coz we don't have a concrete type defined.
            null));
      }

      return new ModelGraphicsInstance(
        modelGraphics,
        position,
        id);
    }
  }
}
