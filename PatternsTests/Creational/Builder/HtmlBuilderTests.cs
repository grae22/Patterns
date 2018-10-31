using NUnit.Framework;
using Patterns.Creational.Builder;

namespace PatternsTests.Creational.Builder
{
  [TestFixture]
  public class HtmlBuilderTests
  {
    [Test]
    public void Build_GivenHtmlBuilder_ShouldReturnHtml()
    {
      // Arrange.
      var builder = new HtmlBuilder();

      builder.AddParagraph("Paragraph text 1...");
      builder.AddBoldText("Bold text");
      builder.AddText("Plain text");
      builder.AddParagraph("Paragraph text 2...");

      // Act.
      string result = builder.Build();

      // Assert.
      Assert.AreEqual(
        "<p>Paragraph text 1...</p><b>Bold text</b>Plain text<p>Paragraph text 2...</p>",
        result);
    }
  }
}
