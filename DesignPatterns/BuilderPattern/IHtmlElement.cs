
namespace BuilderPattern
{
    public interface IHtmlElement
    {
        string Name { get; }

        string Text { get; }

        List<IHtmlElement> Elements { get; }
    }
}