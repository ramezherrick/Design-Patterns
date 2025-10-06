using FactoryPattern.Interfaces;
using FactoryPattern.Models;

namespace FactoryPattern
{
    public class EnglandFactory : IAbstractFactory<EnglandFactory>
    {
        public ICity GetCapital()
        {
            return new London();
        }

        public ILanguage GetLanguage()
        {
            return new English();
        }
    }
}
