using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class Madrid : ICity
    {
        public int GetPopulation()
        {
            return 47350000;
        }
    }
}
