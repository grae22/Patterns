using System.Collections.Generic;
using System.Diagnostics;

using NUnit.Framework;

using Patterns.Structural.Composite;

namespace PatternsTests.Structural.Composite
{
  [TestFixture]
  public class Client
  {
    [Test]
    public void Test()
    {
      var root = new Folder("root");
      var subFolder = new Folder("sub-folder");
      var file1 = new File("file1");
      var file2 = new File("file2");
      var items = new List<IFolderItem>();

      root.AddChild(subFolder);
      root.AddChild(file1);

      subFolder.AddChild(file2);

      items.Add(root);
      items.Add(subFolder);
      items.Add(file1);
      items.Add(file2);

      items.ForEach(i => Debug.WriteLine(i.Name));
    }
  }
}
