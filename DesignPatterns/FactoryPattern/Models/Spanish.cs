using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class Spanish : ILanguage
    {
        public string GetLanguage()
        {
            return "Spanish";
        }
    }
}
