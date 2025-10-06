using FactoryPattern.Interfaces;
using FactoryPattern.Models;

namespace FactoryPattern
{
    public class ThemeFactory : IThemeFactory
    {
        public ITheme CreateTheme(bool isDarkTheme)
        {
            return isDarkTheme ? new DarkTheme() : new LightTheme();
        }
    }
}
