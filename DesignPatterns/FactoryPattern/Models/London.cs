using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class London : ICity
    {
        public int GetPopulation()
        {
            return 8982000;
        }
    }
}
