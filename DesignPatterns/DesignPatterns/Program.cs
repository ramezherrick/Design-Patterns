using BuilderPattern;
using DesignPatterns;
using FactoryPattern;
using FactoryPattern.Interfaces;
using FactoryPattern.Models;
using Microsoft.Extensions.DependencyInjection;

var provider = Main.Start();

var builder = provider.GetRequiredService<HtmlBuilder>();

var themeFactory = provider.GetRequiredService<IThemeFactory>();
var englandFactory = provider.GetRequiredService<IAbstractFactory<EnglandFactory>>();
var spainFactory = provider.GetRequiredService<IAbstractFactory<SpainFactory>>();

var builderPatternHtml = builder
    .AddChild("li", "hello")
    .AddChild("li", "world")
    .Build();

var darkTheme = themeFactory.CreateTheme(isDarkTheme: true);
var englandPopulation = englandFactory.GetCapital().GetPopulation();
var englandLanguage = englandFactory.GetLanguage().GetLanguage();
var spainPopulation = spainFactory.GetCapital().GetPopulation();
var spainLanguage = spainFactory.GetLanguage().GetLanguage();

Console.WriteLine(builderPatternHtml);
Console.WriteLine($"Text color: {darkTheme.TextColor} - BackGroundColor: {darkTheme.BackGroundColor}");
Console.WriteLine($"England population: {englandPopulation} - England Language: {englandLanguage}");
Console.WriteLine($"Spain population: {spainPopulation} - Spain Language: {spainLanguage}");
