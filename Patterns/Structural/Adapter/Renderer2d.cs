namespace Patterns.Structural.Adapter
{
  internal class Renderer2d
  {
    public void DrawBox(
      int x,
      int y,
      int width,
      int height)
    {
      var renderer = new Renderer3d();

      renderer.DrawBox(
        x,
        y,
        width,
        height,
        0);
    }
  }
}
