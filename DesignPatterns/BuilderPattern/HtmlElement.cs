using System.Text;

namespace BuilderPattern
{
    public class HtmlElement : IHtmlElement
    {
        public string Name { get; set; }

        public string Text { get; set; }

        public List<IHtmlElement> Elements { get; set; } = new List<IHtmlElement>();

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }
}
