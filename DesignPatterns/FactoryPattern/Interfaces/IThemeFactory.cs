using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    public interface IThemeFactory
    {
        ITheme CreateTheme(bool isDarkTheme);
    }
}