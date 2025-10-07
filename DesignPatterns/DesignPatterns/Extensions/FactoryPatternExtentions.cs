using FactoryPattern.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternsRunner.Extensions
{
    public static class FactoryPatternExtentions
    {
        public static IServiceCollection RegisterFactoryPattern(this IServiceCollection services)
        {
            services.AddScoped<IThemeFactory, ThemeFactory>();

            services.AddScoped<IAbstractFactory<SpainFactory>, SpainFactory>();
            services.AddScoped<IAbstractFactory<EnglandFactory>, EnglandFactory>();

            return services;
        }
    }
}
