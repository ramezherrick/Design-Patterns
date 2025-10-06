using FactoryPattern;
using FactoryPattern.Interfaces;
using FactoryPattern.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Extensions
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
