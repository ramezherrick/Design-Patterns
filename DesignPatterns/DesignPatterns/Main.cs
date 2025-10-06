using DesignPatterns.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns
{
    public static class Main
    {
        public static ServiceProvider Start()
        {
            var service = new ServiceCollection();

            service.RegisterBuilderPattern();

            return service.BuildServiceProvider();
        }
    }
}
