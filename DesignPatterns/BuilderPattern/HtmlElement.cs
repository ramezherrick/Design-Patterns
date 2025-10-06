using System.Text;

namespace BuilderPattern
{
    public class HtmlElement : IHtmlElement
    {
        public string Name { get;}

        public string Text { get; }

        public List<IHtmlElement> Elements { get; } = new List<IHtmlElement>();

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }
}
