using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class LightTheme : ITheme
    {
        public string TextColor => "black";

        public string BackGroundColor => "white";
    }
}
