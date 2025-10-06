using BuilderPattern;
using DesignPatterns;
using Microsoft.Extensions.DependencyInjection;

var provider = Main.Start();

var builderPatternHtml = provider.GetRequiredService<HtmlBuilder>()
    .AddChild("li", "hello")
    .AddChild("li", "world")
    .Build();

Console.WriteLine(builderPatternHtml);
