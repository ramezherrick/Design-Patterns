
namespace BuilderPattern
{
    public interface IHtmlElement
    {
        string Name { get; set; }

        string Text { get; set; }

        List<IHtmlElement> Elements { get; set; }
    }
}