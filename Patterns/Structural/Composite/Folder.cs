using System.Collections.Generic;

namespace Patterns.Structural.Composite
{
  internal class Folder : IFolderItem
  {
    public string Name { get; }
    public IReadOnlyList<IFolderItem> Children => _children;

    private readonly List<IFolderItem> _children = new List<IFolderItem>();

    public Folder(in string name)
    {
      Name = name;
    }

    public void AddChild(in IFolderItem child)
    {
      _children.Add(child);
    }
  }
}
