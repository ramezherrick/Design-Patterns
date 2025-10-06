using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class English : ILanguage
    {
        public string GetLanguage()
        {
            return "English";
        }
    }
}
