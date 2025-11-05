using BuilderPattern;
using DesignPatternsRunner;
using FactoryPattern.Factories;
using Microsoft.Extensions.DependencyInjection;
using PrototypePattern.Models;
using SingletonPattern;

var provider = Main.Start();

// Builder Pattern
var builder = provider.GetRequiredService<HtmlBuilder>();
var builderPatternHtml = builder
    .AddChild("li", "hello")
    .AddChild("li", "world")
    .Build();
Console.WriteLine(builderPatternHtml);

// Factory Pattern
var themeFactory = provider.GetRequiredService<IThemeFactory>();
var darkTheme = themeFactory.CreateTheme(isDarkTheme: true);
Console.WriteLine($"Dark Theme text color: {darkTheme.TextColor} - background color: {darkTheme.BackGroundColor}");


// Abstract Factory Pattern
var englandFactory = provider.GetRequiredService<IAbstractFactory<EnglandFactory>>();
var spainFactory = provider.GetRequiredService<IAbstractFactory<SpainFactory>>();

var englandPopulation = englandFactory.GetCapital().GetPopulation();
var englandLanguage = englandFactory.GetLanguage().GetLanguage();
var spainPopulation = spainFactory.GetCapital().GetPopulation();
var spainLanguage = spainFactory.GetLanguage().GetLanguage();

Console.WriteLine($"England population: {englandPopulation} - England Language: {englandLanguage}");
Console.WriteLine($"Spain population: {spainPopulation} - Spain Language: {spainLanguage}");

// Prototype Pattern
var employee = new Employee(
    names: ["John", "Smith"],
    address: new Address("Carpenter Road", 123),
    salary: 50000);

var employeeCopy = employee.DeepCopy();

employeeCopy.Names[0] = "Jane";
employeeCopy.Address.HouseNumber = 321;
employeeCopy.Salary = 60000;

Console.WriteLine(
    $"Original Employee: {string.Join(" ", employee.Names)}," +
    $"Address: {employee.Address.HouseNumber} - {employee.Address.StreetName}," +
    $"Salary: {employee.Salary}");
Console.WriteLine(
    $"Copied Employee: {string.Join(" ", employeeCopy.Names)}, " +
    $"Address: {employeeCopy.Address.HouseNumber} - {employeeCopy.Address.StreetName}," +
    $"Salary: {employeeCopy.Salary}");

// Singleton Pattern
var hostOne =  TableServers.GetTableServersInstance();
var hostTwo = TableServers.GetTableServersInstance();

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Host One - Request {i} assigned to table server: {hostOne.GetNextServer()}");
    Console.WriteLine($"Host Two - Request {i} assigned to table server: {hostTwo.GetNextServer()}");
}











