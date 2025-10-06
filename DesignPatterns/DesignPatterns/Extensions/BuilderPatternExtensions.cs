using BuilderPattern;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Extensions
{
    public static class BuilderPatternExtensions
    {
        public static IServiceCollection RegisterBuilderPattern(this IServiceCollection services)
        {
            services
                .AddScoped<IHtmlElement, HtmlElement>(x => new HtmlElement("ul", string.Empty));
            services
                .AddScoped<Func<string, string, IHtmlElement>>(x => (name, text) => new HtmlElement(name, text));
            
            services.AddScoped<HtmlBuilder>(x =>
            {
                var parent = x.GetRequiredService<IHtmlElement>();
                var childFactory = x.GetRequiredService<Func<string, string, IHtmlElement>>();
                return new HtmlBuilder(parent, childFactory);
            });

            return services;
        }
    }
}
