using FactoryPattern.Interfaces;

namespace FactoryPattern.Factories
{
    public interface IThemeFactory
    {
        ITheme CreateTheme(bool isDarkTheme);
    }
}