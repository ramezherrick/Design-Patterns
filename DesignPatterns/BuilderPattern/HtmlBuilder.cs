using System.Text;

namespace BuilderPattern
{
    public class HtmlBuilder
    {
        private readonly IHtmlElement _parent;
        private readonly Func<string, string, IHtmlElement> _child;

        public HtmlBuilder(IHtmlElement parent, Func<string, string, IHtmlElement> child)
        {
            _parent = parent;
            _child = child;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var element = _child(childName, childText);
            _parent.Elements.Add(element);
            return this;
        }

        public string Build()
        {
            var stringBuilder = new StringBuilder();
            
            BuildElement(_parent, stringBuilder, indent: 0);

            return stringBuilder.ToString();
        }

        public void BuildElement(IHtmlElement element, StringBuilder stringBuilder, int indent)
        {
            var indentation = new string(' ', indent * 2);

            stringBuilder.AppendLine($"{indentation}<{element.Name}>");

            if (!string.IsNullOrWhiteSpace(element.Text))
            {
                stringBuilder.AppendLine($"{indentation}  {element.Text}");
            }

            foreach (var child in element.Elements)
            {
                BuildElement(child, stringBuilder, indent + 1);
            }

            stringBuilder.AppendLine($"{indentation}</{element.Name}>");
        }
    }
}
