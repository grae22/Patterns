namespace Patterns.Structural.Flyweight
{
  internal class ModelGraphics : IModelGraphics
  {
    public ITexture Texture { get; }
    public IShader Shader { get; }

    public ModelGraphics(
      in ITexture texture,
      in IShader shader)
    {
      Texture = texture;
      Shader = shader;
    }
  }
}
