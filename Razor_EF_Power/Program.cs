using Razor_EF_Power.Models;

using var context = new Razor_EFContext();

var clients = context.Products.ToList();

foreach (var p in clients)
{
    Console.WriteLine($"{p.Name} {p.Price}" );
}