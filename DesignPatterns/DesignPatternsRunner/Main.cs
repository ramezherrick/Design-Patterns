using DesignPatternsRunner.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternsRunner
{
    public static class Main
    {
        public static ServiceProvider Start()
        {
            var service = new ServiceCollection();

            service
                .RegisterBuilderPattern()
                .RegisterFactoryPattern()
                .RegisterPrototypePattern();

            return service.BuildServiceProvider();
        }
    }
}
