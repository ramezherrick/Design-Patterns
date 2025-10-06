using FactoryPattern.Interfaces;
using FactoryPattern.Models;

namespace FactoryPattern
{
    public class SpainFactory : IAbstractFactory<SpainFactory>
    {
        public ICity GetCapital()
        {
            return new Madrid();
        }

        public ILanguage GetLanguage()
        {
            return new Spanish();
        }
    }
}
