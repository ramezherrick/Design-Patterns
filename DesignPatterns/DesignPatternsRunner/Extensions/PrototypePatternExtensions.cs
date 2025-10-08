using Microsoft.Extensions.DependencyInjection;
using PrototypePattern;
using PrototypePattern.Models;

namespace DesignPatternsRunner.Extensions
{
    public static class PrototypePatternExtensions
    {
        public static IServiceCollection RegisterPrototypePattern(this IServiceCollection services)
        {
            services.AddScoped<DeepCopyable<Address>, Address>();
            services.AddScoped<DeepCopyable<Person>, Person>();

            return services;
        }
    }
}
