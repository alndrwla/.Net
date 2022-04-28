// See https://aka.ms/new-console-template for more information

using Humanizer;

Console.WriteLine("What's your name!");
var name = Console.ReadLine();
Console.WriteLine("Add your job!");
var job = Console.ReadLine();
Console.WriteLine("Add your age!");
try
{
    var age = int.Parse(Console.ReadLine());
    Console.WriteLine($"Mi nombre es {name} y mi cargo es {job} y mi edad es {age.ToWords(new System.Globalization.CultureInfo("es"))},");
}  catch (Exception)
{
    Console.WriteLine("Invalid age!");
}

