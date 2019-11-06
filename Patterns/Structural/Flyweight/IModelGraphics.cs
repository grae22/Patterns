namespace Patterns.Structural.Flyweight
{
  internal interface IModelGraphics
  {
    ITexture Texture { get; }
    IShader Shader { get; }
  }
}
