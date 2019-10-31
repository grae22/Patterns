namespace Patterns.Structural.Composite
{
  internal class File : IFolderItem
  {
    public string Name { get; }

    public File(in string name)
    {
      Name = name;
    }
  }
}
