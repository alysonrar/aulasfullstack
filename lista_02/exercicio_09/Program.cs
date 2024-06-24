// See https://aka.ms/new-console-template for more information
using System.Globalization;

Double altura,peso;

Console.Write("Digite sua Altura: ");
altura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
peso =72.7 * altura - 58;
Console.WriteLine($"Seu Peso Ideal é :{peso.ToString("F2", CultureInfo.InvariantCulture)}");

