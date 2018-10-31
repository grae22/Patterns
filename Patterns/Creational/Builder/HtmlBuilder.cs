using System.Text;

namespace Patterns.Creational.Builder
{
  internal class HtmlBuilder
  {
    private readonly StringBuilder _resultBuilder = new StringBuilder();

    public string Build()
    {
      return _resultBuilder.ToString();
    }

    public void AddParagraph(string text)
    {
      _resultBuilder.Append($"<p>{text}</p>");
    }

    public void AddBoldText(string text)
    {
      _resultBuilder.Append($"<b>{text}</b>");
    }

    public void AddText(string text)
    {
      _resultBuilder.Append(text);
    }
  }
}
