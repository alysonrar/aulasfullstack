// See https://aka.ms/new-console-template for more information
using System.Security.Principal;

Console.WriteLine("Saiba sua idade convertida em total de dias");
byte anos , meses , dias;
Console.Write("Para comerçamos insira a sua idade atual: ");
anos = byte.Parse(Console.ReadLine());
Console.Write("Insira os meses: ");
meses = byte.Parse(Console.ReadLine());
Console.Write("Insira os dias: ");
dias = byte.Parse(Console.ReadLine());
int total;
total= anos * 365;
total= total + meses * 30;
total= total +dias;
Console.WriteLine($"O valor total de dias é: {total} ");